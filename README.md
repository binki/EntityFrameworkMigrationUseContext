# Usage

First, set a connection string. For example:

    >set-connection
    connection=Data Source=(LocalDb)\v11.0;Integrated Security=true;Initial Catalog=efmig0

If you want database initialization to succeed, you will need to manually opt-in to `useSuppliedContext` by issuing the `workaround-initialization` command. Otherwise, you will get the default value of `false` which will lead to failure which is intentionally left in place for demonstration purposes for [aspnet/EntityFramework#563](https://github.com/aspnet/EntityFramework6/issues/563):

    >workaround-initialization

Then perform commands such as `add` and `list`:

    >add
    name=My Name
    email=user@example.com
    >list
    user@example.com name=My Name
