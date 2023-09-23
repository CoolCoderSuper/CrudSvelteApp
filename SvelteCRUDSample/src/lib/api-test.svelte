<script>
    import { Input, Button } from 'flowbite-svelte'

    let name = ''

    let sayHello = async () => {
        let res = await fetch(`http://localhost:4567/hello/${name}`)
        if (res.ok){
            alert(await res.text())
        }else{
            alert(`Error: ${res.status}`)
        }
    }

    let sayBye = async () => {
        let res = await fetch(`http://localhost:4567/bye/${name}`)
        if (res.ok){
            alert(await res.text())
        }else{
            alert(`Error: ${res.status}`)
        }
    }
</script>

<Input bind:value={name} placeholder="Name"/>
<Button on:click={sayHello}>Say hello</Button>

<Input bind:value={name} placeholder="Name"/>
<Button on:click={sayBye}>Say bye</Button>