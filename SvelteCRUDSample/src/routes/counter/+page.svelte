<script>
  import { Button, NumberInput } from "flowbite-svelte";

  let count = 0;
  function increment() {
    count += 1;
  }

  function decrement() {
    count -= 1;
  }
</script>

<NumberInput bind:value={count} />
<table>
  <tr>
    <td><Button on:click={increment}>+</Button></td>
    <td><Button on:click={decrement}>-</Button></td>
  </tr>
</table>
