//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace gaia.webforms.test
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductPhoto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductPhoto()
        {
            this.ProductProductPhoto = new HashSet<ProductProductPhoto>();
        }
    
        public int ProductPhotoID { get; set; }
        public byte[] ThumbNailPhoto { get; set; }
        public string ThumbnailPhotoFileName { get; set; }
        public byte[] LargePhoto { get; set; }
        public string LargePhotoFileName { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductProductPhoto> ProductProductPhoto { get; set; }
    }
}
