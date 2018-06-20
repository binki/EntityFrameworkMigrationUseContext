# Usage

First, set a connection string. For example:

    >set-connection
    connection=Data Source=(LocalDb)\v11.0;Integrated Security=true;Initial Catalog=efmig0

Then perform commands such as `add` and `list`:

    >add
    name=My Name
    email=user@example.com
    >list
    user@example.com name=My Name
