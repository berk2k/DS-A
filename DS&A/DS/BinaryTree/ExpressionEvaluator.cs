public class ExpressionEvaluator
{
	public static int EvaluatePostfix(string[] tokens)
	{
		Stack<int> stack = new Stack<int>();

		foreach (var token in tokens)
		{
			if (int.TryParse(token, out int num))
			{
				stack.Push(num);
			}
			else
			{
				int b = stack.Pop();
				int a = stack.Pop();
				switch (token)
				{
					case "+": stack.Push(a + b); break;
					case "-": stack.Push(a - b); break;
					case "*": stack.Push(a * b); break;
					case "/": stack.Push(a / b); break;
				}
			}
		}

		return stack.Pop();
	}
}
