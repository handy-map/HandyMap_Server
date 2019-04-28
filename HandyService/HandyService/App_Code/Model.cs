﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;


public partial class Certificate
{

    public int CertificateId { get; set; }

    public int WorkerId { get; set; }



    public virtual Worker Worker { get; set; }

}


public partial class Client : User
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Client()
    {

        this.Jobs = new HashSet<Job>();

    }


    public int ClientId { get; set; }

    public string Email { get; set; }

    public string Name { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Job> Jobs { get; set; }

}


public partial class Job
{

    public string JobId { get; set; }

    public int ClientId { get; set; }

    public int WorkerId { get; set; }

    public string Task { get; set; }



    public virtual Client Client { get; set; }

    public virtual Worker Worker { get; set; }

}


public partial class User
{

    public int UserId { get; set; }

}


public partial class Worker : User
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Worker()
    {

        this.Jobs = new HashSet<Job>();

        this.Certificates = new HashSet<Certificate>();

    }


    public int WorkerId { get; set; }

    public string Name { get; set; }

    public string Surname { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Job> Jobs { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Certificate> Certificates { get; set; }

}

