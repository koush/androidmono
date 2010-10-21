namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicTokenIterator : java.lang.Object, TokenIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicTokenIterator()
		{
			InitJNI();
		}
		protected BasicTokenIterator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasNext33532;
		public virtual bool hasNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator._hasNext33532);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._hasNext33532);
		}
		internal static global::MonoJavaBridge.MethodId _next33533;
		public virtual global::java.lang.Object next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator._next33533)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._next33533)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove33534;
		public virtual void remove() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator._remove33534);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._remove33534);
		}
		internal static global::MonoJavaBridge.MethodId _isWhitespace33535;
		protected virtual bool isWhitespace(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator._isWhitespace33535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._isWhitespace33535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextToken33536;
		public virtual global::java.lang.String nextToken() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator._nextToken33536)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._nextToken33536)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _findTokenStart33537;
		protected virtual int findTokenStart(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator._findTokenStart33537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._findTokenStart33537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findTokenEnd33538;
		protected virtual int findTokenEnd(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator._findTokenEnd33538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._findTokenEnd33538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findNext33539;
		protected virtual int findNext(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator._findNext33539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._findNext33539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createToken33540;
		protected virtual global::java.lang.String createToken(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator._createToken33540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._createToken33540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _findTokenSeparator33541;
		protected virtual int findTokenSeparator(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator._findTokenSeparator33541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._findTokenSeparator33541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isTokenSeparator33542;
		protected virtual bool isTokenSeparator(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator._isTokenSeparator33542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._isTokenSeparator33542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isTokenChar33543;
		protected virtual bool isTokenChar(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator._isTokenChar33543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._isTokenChar33543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isHttpSeparator33544;
		protected virtual bool isHttpSeparator(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator._isHttpSeparator33544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._isHttpSeparator33544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BasicTokenIterator33545;
		public BasicTokenIterator(org.apache.http.HeaderIterator arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._BasicTokenIterator33545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static global::java.lang.String HTTP_SEPARATORS
		{
			get
			{
				return " ,;=()<>@:\\\"/[]?{}	";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicTokenIterator.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicTokenIterator"));
			global::org.apache.http.message.BasicTokenIterator._hasNext33532 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "hasNext", "()Z");
			global::org.apache.http.message.BasicTokenIterator._next33533 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "next", "()Ljava/lang/Object;");
			global::org.apache.http.message.BasicTokenIterator._remove33534 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "remove", "()V");
			global::org.apache.http.message.BasicTokenIterator._isWhitespace33535 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "isWhitespace", "(C)Z");
			global::org.apache.http.message.BasicTokenIterator._nextToken33536 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "nextToken", "()Ljava/lang/String;");
			global::org.apache.http.message.BasicTokenIterator._findTokenStart33537 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "findTokenStart", "(I)I");
			global::org.apache.http.message.BasicTokenIterator._findTokenEnd33538 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "findTokenEnd", "(I)I");
			global::org.apache.http.message.BasicTokenIterator._findNext33539 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "findNext", "(I)I");
			global::org.apache.http.message.BasicTokenIterator._createToken33540 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "createToken", "(Ljava/lang/String;II)Ljava/lang/String;");
			global::org.apache.http.message.BasicTokenIterator._findTokenSeparator33541 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "findTokenSeparator", "(I)I");
			global::org.apache.http.message.BasicTokenIterator._isTokenSeparator33542 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "isTokenSeparator", "(C)Z");
			global::org.apache.http.message.BasicTokenIterator._isTokenChar33543 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "isTokenChar", "(C)Z");
			global::org.apache.http.message.BasicTokenIterator._isHttpSeparator33544 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "isHttpSeparator", "(C)Z");
			global::org.apache.http.message.BasicTokenIterator._BasicTokenIterator33545 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "<init>", "(Lorg/apache/http/HeaderIterator;)V");
		}
	}
}
