using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using CleanDDDCQRS.Application;

[ApiController]
[Route("api/[controller]")]
public class CustomersController : ControllerBase
{
    private readonly IMediator _mediator;

    public CustomersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateCustomer([FromBody] CreateCustomerCommand command)
    {
        var customerId = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetCustomer), new { id = customerId }, customerId);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCustomer(Guid id, [FromBody] UpdateCustomerCommand command)
    {
        command.CustomerId = id;
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCustomer(Guid id)
    {
        var query = new GetCustomerQuery { CustomerId = id };
        var customer = await _mediator.Send(query);
        return Ok(customer);
    }

    [HttpGet]
    public async Task<IActionResult> GetCustomers()
    {
        var query = new GetCustomersQuery();
        var customers = await _mediator.Send(query);
        return Ok(customers);
    }
   
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCustomer(Guid id)
    {
        var command = new DeleteCustomerCommand { CustomerId = id };
        await _mediator.Send(command);
        return NoContent();
    }


}
