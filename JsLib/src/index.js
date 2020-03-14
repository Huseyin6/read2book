import swal from 'sweetalert';
export async function Confirm(){
    var willDelete = await swal({
        title: "Book Delete",
        text: "Are you sure?",
        icon: "warning",
        buttons: true,
        dangerMode: true,
      })
      .then((willDelete) => {
        if (willDelete) 
        {
            return true;
        } 
        else 
        {
            return false;
        }
    });
    return willDelete;
}

