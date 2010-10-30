namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicTokenIterator : java.lang.Object, TokenIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicTokenIterator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasNext33651;
		public virtual bool hasNext()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._hasNext33651);
		}
		internal static global::MonoJavaBridge.MethodId _next33652;
		public virtual global::java.lang.Object next()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._next33652)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove33653;
		public virtual void remove()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._remove33653);
		}
		internal static global::MonoJavaBridge.MethodId _isWhitespace33654;
		protected virtual bool isWhitespace(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._isWhitespace33654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextToken33655;
		public virtual global::java.lang.String nextToken()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._nextToken33655)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _findTokenStart33656;
		protected virtual int findTokenStart(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._findTokenStart33656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findTokenEnd33657;
		protected virtual int findTokenEnd(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._findTokenEnd33657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findNext33658;
		protected virtual int findNext(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._findNext33658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createToken33659;
		protected virtual global::java.lang.String createToken(java.lang.String arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._createToken33659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _findTokenSeparator33660;
		protected virtual int findTokenSeparator(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._findTokenSeparator33660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isTokenSeparator33661;
		protected virtual bool isTokenSeparator(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._isTokenSeparator33661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isTokenChar33662;
		protected virtual bool isTokenChar(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._isTokenChar33662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isHttpSeparator33663;
		protected virtual bool isHttpSeparator(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._isHttpSeparator33663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BasicTokenIterator33664;
		public BasicTokenIterator(org.apache.http.HeaderIterator arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._BasicTokenIterator33664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static global::java.lang.String HTTP_SEPARATORS
		{
			get
			{
				return " ,;=()<>@:\\\"/[]?{}	";
			}
		}
		static BasicTokenIterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicTokenIterator.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicTokenIterator"));
			global::org.apache.http.message.BasicTokenIterator._hasNext33651 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "hasNext", "()Z");
			global::org.apache.http.message.BasicTokenIterator._next33652 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "next", "()Ljava/lang/Object;");
			global::org.apache.http.message.BasicTokenIterator._remove33653 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "remove", "()V");
			global::org.apache.http.message.BasicTokenIterator._isWhitespace33654 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "isWhitespace", "(C)Z");
			global::org.apache.http.message.BasicTokenIterator._nextToken33655 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "nextToken", "()Ljava/lang/String;");
			global::org.apache.http.message.BasicTokenIterator._findTokenStart33656 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "findTokenStart", "(I)I");
			global::org.apache.http.message.BasicTokenIterator._findTokenEnd33657 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "findTokenEnd", "(I)I");
			global::org.apache.http.message.BasicTokenIterator._findNext33658 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "findNext", "(I)I");
			global::org.apache.http.message.BasicTokenIterator._createToken33659 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "createToken", "(Ljava/lang/String;II)Ljava/lang/String;");
			global::org.apache.http.message.BasicTokenIterator._findTokenSeparator33660 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "findTokenSeparator", "(I)I");
			global::org.apache.http.message.BasicTokenIterator._isTokenSeparator33661 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "isTokenSeparator", "(C)Z");
			global::org.apache.http.message.BasicTokenIterator._isTokenChar33662 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "isTokenChar", "(C)Z");
			global::org.apache.http.message.BasicTokenIterator._isHttpSeparator33663 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "isHttpSeparator", "(C)Z");
			global::org.apache.http.message.BasicTokenIterator._BasicTokenIterator33664 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "<init>", "(Lorg/apache/http/HeaderIterator;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
