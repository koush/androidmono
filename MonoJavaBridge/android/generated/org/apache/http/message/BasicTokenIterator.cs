namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicTokenIterator : java.lang.Object, TokenIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicTokenIterator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual bool hasNext()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.message.BasicTokenIterator.staticClass, "hasNext", "()Z", ref global::org.apache.http.message.BasicTokenIterator._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object next()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicTokenIterator.staticClass, "next", "()Ljava/lang/Object;", ref global::org.apache.http.message.BasicTokenIterator._m1) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void remove()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.BasicTokenIterator.staticClass, "remove", "()V", ref global::org.apache.http.message.BasicTokenIterator._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected virtual bool isWhitespace(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.message.BasicTokenIterator.staticClass, "isWhitespace", "(C)Z", ref global::org.apache.http.message.BasicTokenIterator._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.String nextToken()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.message.BasicTokenIterator.staticClass, "nextToken", "()Ljava/lang/String;", ref global::org.apache.http.message.BasicTokenIterator._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected virtual int findTokenStart(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.message.BasicTokenIterator.staticClass, "findTokenStart", "(I)I", ref global::org.apache.http.message.BasicTokenIterator._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected virtual int findTokenEnd(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.message.BasicTokenIterator.staticClass, "findTokenEnd", "(I)I", ref global::org.apache.http.message.BasicTokenIterator._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected virtual int findNext(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.message.BasicTokenIterator.staticClass, "findNext", "(I)I", ref global::org.apache.http.message.BasicTokenIterator._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected virtual global::java.lang.String createToken(java.lang.String arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.message.BasicTokenIterator.staticClass, "createToken", "(Ljava/lang/String;II)Ljava/lang/String;", ref global::org.apache.http.message.BasicTokenIterator._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected virtual int findTokenSeparator(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.message.BasicTokenIterator.staticClass, "findTokenSeparator", "(I)I", ref global::org.apache.http.message.BasicTokenIterator._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected virtual bool isTokenSeparator(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.message.BasicTokenIterator.staticClass, "isTokenSeparator", "(C)Z", ref global::org.apache.http.message.BasicTokenIterator._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected virtual bool isTokenChar(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.message.BasicTokenIterator.staticClass, "isTokenChar", "(C)Z", ref global::org.apache.http.message.BasicTokenIterator._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		protected virtual bool isHttpSeparator(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.message.BasicTokenIterator.staticClass, "isHttpSeparator", "(C)Z", ref global::org.apache.http.message.BasicTokenIterator._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public BasicTokenIterator(org.apache.http.HeaderIterator arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicTokenIterator._m13.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicTokenIterator._m13 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "<init>", "(Lorg/apache/http/HeaderIterator;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		}
		internal static void InitJNI()
		{
		}
	}
}
