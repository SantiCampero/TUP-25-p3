﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace servidor.Migrations
{
    [DbContext(typeof(TiendaContext))]
    [Migration("20250610224518_AddCompras")]
    partial class AddCompras
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.5");

            modelBuilder.Entity("Carrito", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Carritos");
                });

            modelBuilder.Entity("Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ApellidoCliente")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailCliente")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreCliente")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Total")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("ItemCarrito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CarritoId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CarritoId");

                    b.HasIndex("ProductoId");

                    b.ToTable("ItemCarrito");
                });

            modelBuilder.Entity("ItemCompra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CompraId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CompraId");

                    b.HasIndex("ProductoId");

                    b.ToTable("ItemsCompra");
                });

            modelBuilder.Entity("Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagenUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Precio")
                        .HasColumnType("TEXT");

                    b.Property<int>("Stock")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "Guitarra Telecaster de lujo con acabado premium.",
                            ImagenUrl = "/imagenes/american-luxe-telecaster.png",
                            Nombre = "American Luxe Telecaster",
                            Precio = 2500m,
                            Stock = 5
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "Telecaster con cuerpo blanco y sonido potente.",
                            ImagenUrl = "/imagenes/american-telecaster-blanca.png",
                            Nombre = "American Telecaster Blanca",
                            Precio = 2200m,
                            Stock = 4
                        },
                        new
                        {
                            Id = 3,
                            Descripcion = "Stratocaster ideal para músicos profesionales.",
                            ImagenUrl = "/imagenes/stratocaster-professional-ii.png",
                            Nombre = "Stratocaster Professional II",
                            Precio = 2300m,
                            Stock = 6
                        },
                        new
                        {
                            Id = 4,
                            Descripcion = "Modelo Telecaster con estética y tono vintage.",
                            ImagenUrl = "/imagenes/vintage-telecaster.png",
                            Nombre = "Vintage Telecaster",
                            Precio = 2100m,
                            Stock = 3
                        });
                });

            modelBuilder.Entity("ItemCarrito", b =>
                {
                    b.HasOne("Carrito", null)
                        .WithMany("Items")
                        .HasForeignKey("CarritoId");

                    b.HasOne("Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("ItemCompra", b =>
                {
                    b.HasOne("Compra", "Compra")
                        .WithMany("Items")
                        .HasForeignKey("CompraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Compra");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Carrito", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Compra", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
