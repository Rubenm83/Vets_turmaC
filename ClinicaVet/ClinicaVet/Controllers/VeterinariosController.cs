using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClinicaVet.Data;
using ClinicaVet.Models;

namespace ClinicaVet.Controllers
{
    public class VeterinariosController : Controller
    {
        /// <summary>
        /// Este atributo representa uma referência à nossa base de dados
        /// </summary>
        private readonly VetsDB db;

        public VeterinariosController(VetsDB context)
        {
            db = context;
        }




        
        // GET: Veterinarios
        public async Task<IActionResult> Index()
        {
            //db.Veterinario.ToLisAsync()
            //LINQ

            return View(await db.Veterinarios.ToListAsync());
        }






        // GET: Veterinarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veterinarios = await db.Veterinarios
                .FirstOrDefaultAsync(m => m.ID == id);
            if (veterinarios == null)
            {
                return NotFound();
            }

            return View(veterinarios);
        }

        // GET: Veterinarios/Create
        //Invocar a view de Criação de um novo veterinário
        public IActionResult Create()
        {
            return View();
        }

        // POST: Veterinarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        /// <summary>
        /// Concretizar a escrita de um novo veterinário.
        /// </summary>
        /// <param name="veterinario">dados do novo veterinário</param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nome,NumCedulaProf,Fotografia")] Veterinarios veterinario)
        {





            if (ModelState.IsValid)
            {
                //adiciona o novo veterinario à BD, mas na memória do Servidor ASP .net
                db.Add(veterinario);
                // consolida os dados no Servidor BD (Commit)
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //qd ocorre um erro,reenvio os dados do veterinário para a view da criação
            return View(veterinario);
        }

        // GET: Veterinarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veterinarios = await db.Veterinarios.FindAsync(id);
            if (veterinarios == null)
            {
                return NotFound();
            }
            return View(veterinarios);
        }

        // POST: Veterinarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nome,NumCedulaProf,Fotografia")] Veterinarios veterinarios)
        {
            if (id != veterinarios.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(veterinarios);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VeterinariosExists(veterinarios.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(veterinarios);
        }



        // GET: Veterinarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veterinarios = await db.Veterinarios
                .FirstOrDefaultAsync(m => m.ID == id);
            if (veterinarios == null)
            {
                return NotFound();
            }

            return View(veterinarios);
        }

        // POST: Veterinarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var veterinarios = await db.Veterinarios.FindAsync(id);
            db.Veterinarios.Remove(veterinarios);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VeterinariosExists(int id)
        {
            return db.Veterinarios.Any(e => e.ID == id);
        }
    }
}
