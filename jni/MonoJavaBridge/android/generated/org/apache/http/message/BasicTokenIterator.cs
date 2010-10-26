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
		internal static global::MonoJavaBridge.MethodId _hasNext33650;
		public virtual bool hasNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator._hasNext33650);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._hasNext33650);
		}
		internal static global::MonoJavaBridge.MethodId _next33651;
		public virtual global::java.lang.Object next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator._next33651)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._next33651)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove33652;
		public virtual void remove() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator._remove33652);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._remove33652);
		}
		internal static global::MonoJavaBridge.MethodId _isWhitespace33653;
		protected virtual bool isWhitespace(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator._isWhitespace33653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._isWhitespace33653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextToken33654;
		public virtual global::java.lang.String nextToken() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator._nextToken33654)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._nextToken33654)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _findTokenStart33655;
		protected virtual int findTokenStart(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator._findTokenStart33655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._findTokenStart33655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findTokenEnd33656;
		protected virtual int findTokenEnd(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator._findTokenEnd33656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._findTokenEnd33656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findNext33657;
		protected virtual int findNext(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator._findNext33657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._findNext33657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createToken33658;
		protected virtual global::java.lang.String createToken(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator._createToken33658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._createToken33658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _findTokenSeparator33659;
		protected virtual int findTokenSeparator(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator._findTokenSeparator33659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._findTokenSeparator33659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isTokenSeparator33660;
		protected virtual bool isTokenSeparator(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator._isTokenSeparator33660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._isTokenSeparator33660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isTokenChar33661;
		protected virtual bool isTokenChar(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator._isTokenChar33661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._isTokenChar33661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isHttpSeparator33662;
		protected virtual bool isHttpSeparator(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator._isHttpSeparator33662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._isHttpSeparator33662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BasicTokenIterator33663;
		public BasicTokenIterator(org.apache.http.HeaderIterator arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicTokenIterator.staticClass, global::org.apache.http.message.BasicTokenIterator._BasicTokenIterator33663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::org.apache.http.message.BasicTokenIterator._hasNext33650 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "hasNext", "()Z");
			global::org.apache.http.message.BasicTokenIterator._next33651 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "next", "()Ljava/lang/Object;");
			global::org.apache.http.message.BasicTokenIterator._remove33652 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "remove", "()V");
			global::org.apache.http.message.BasicTokenIterator._isWhitespace33653 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "isWhitespace", "(C)Z");
			global::org.apache.http.message.BasicTokenIterator._nextToken33654 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "nextToken", "()Ljava/lang/String;");
			global::org.apache.http.message.BasicTokenIterator._findTokenStart33655 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "findTokenStart", "(I)I");
			global::org.apache.http.message.BasicTokenIterator._findTokenEnd33656 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "findTokenEnd", "(I)I");
			global::org.apache.http.message.BasicTokenIterator._findNext33657 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "findNext", "(I)I");
			global::org.apache.http.message.BasicTokenIterator._createToken33658 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "createToken", "(Ljava/lang/String;II)Ljava/lang/String;");
			global::org.apache.http.message.BasicTokenIterator._findTokenSeparator33659 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "findTokenSeparator", "(I)I");
			global::org.apache.http.message.BasicTokenIterator._isTokenSeparator33660 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "isTokenSeparator", "(C)Z");
			global::org.apache.http.message.BasicTokenIterator._isTokenChar33661 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "isTokenChar", "(C)Z");
			global::org.apache.http.message.BasicTokenIterator._isHttpSeparator33662 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "isHttpSeparator", "(C)Z");
			global::org.apache.http.message.BasicTokenIterator._BasicTokenIterator33663 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicTokenIterator.staticClass, "<init>", "(Lorg/apache/http/HeaderIterator;)V");
		}
	}
}
