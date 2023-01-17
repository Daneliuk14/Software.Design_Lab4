using Microsoft.EntityFrameworkCore;
using Software.Design.DataModels;
using Software.Design.Models;

namespace Software.Design.Services;

public class KeyboardServices
{
    private readonly KeyboardContext _dbContext;

    public KeyboardServices(KeyboardContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Keyboard>> GetProducts()
    {
        var products = await _dbContext.KeyboardDB.ToListAsync();
        return products;
    }
    public async Task<Keyboard> Delete(int ID)
    {
       var value = await _dbContext.KeyboardDB.Where(x => x.id == ID).FirstOrDefaultAsync();
       
       _dbContext.KeyboardDB.Remove(value);
        await _dbContext.SaveChangesAsync();
        await _dbContext.KeyboardDB.ToListAsync();
        return value;
    }

    public async Task<Keyboard> Create(KeyboardDTO keyboardDTO)
    {
        var product = new Keyboard(keyboardDTO);

        await _dbContext.KeyboardDB.AddAsync(product);
        await _dbContext.SaveChangesAsync();
        return product;
    }

    public async Task<Keyboard> Get(int ID)
    {
        var value = await _dbContext.KeyboardDB.Where(x => x.id == ID).FirstOrDefaultAsync();
        return value;
    }

    public async Task<Keyboard> Update(int ID, KeyboardDTO keyboardDTO)
    {
        var value = await _dbContext.KeyboardDB.Where(x => x.id == ID).FirstOrDefaultAsync();
        value.manufacturerid = keyboardDTO.manufacturerid;
        value.name = keyboardDTO.name;
        value.backlight = keyboardDTO.backlight;
        value.colour = keyboardDTO.colour;
        await _dbContext.SaveChangesAsync();
        return value;
    }

}