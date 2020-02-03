﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroPessoa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CadastroPessoa.Controllers
{
    public class PessoaController : Controller
    {

        private readonly Contexto _contexto;

        public PessoaController(Contexto contexto)
        {
            _contexto = contexto;     
        }

        public async Task<IActionResult> Index()
        {
            return View( await _contexto.Pessoas.ToListAsync());
        }

        //devolve dados pra view
        [HttpGet]
        public IActionResult CriarPessoa()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CriarPessoa(Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                _contexto.Add(pessoa);

                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            else return View(pessoa);
             
        }

        [HttpGet]
        public IActionResult AtualizarPessoa(int? id)
        {
            if(id != null)
            {
                Pessoa pessoa = _contexto.Pessoas.Find(id);
                return View(pessoa);
            }
            else return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> AtualizarPessoa(int? id,Pessoa pessoa)
        {
            if (id != null)
            {
                if (ModelState.IsValid)
                {
                    _contexto.Update(pessoa);
                    await _contexto.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else return View(pessoa);
            }
            else return NotFound();
        }

        [HttpGet]
        public IActionResult ExcluirPessoa(int? id)
        {
            if (id != null)
            {
                Pessoa pessoa = _contexto.Pessoas.Find(id);
                return View(pessoa);
            }
            else return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> ExcluirPessoa(int? id, Pessoa pessoa)
        {
            if (id != null)
            {
                _contexto.Remove(pessoa);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else return NotFound();
        }




    }
}