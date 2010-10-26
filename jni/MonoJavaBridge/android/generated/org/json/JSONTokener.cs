namespace org.json
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JSONTokener : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static JSONTokener()
		{
			InitJNI();
		}
		protected JSONTokener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString34136;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONTokener._toString34136)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._toString34136)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _next34137;
		public virtual global::java.lang.String next(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONTokener._next34137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._next34137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _next34138;
		public virtual char next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::org.json.JSONTokener._next34138);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._next34138);
		}
		internal static global::MonoJavaBridge.MethodId _next34139;
		public virtual char next(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::org.json.JSONTokener._next34139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._next34139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _more34140;
		public virtual bool more() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.json.JSONTokener._more34140);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._more34140);
		}
		internal static global::MonoJavaBridge.MethodId _nextValue34141;
		public virtual global::java.lang.Object nextValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONTokener._nextValue34141)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._nextValue34141)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _nextString34142;
		public virtual global::java.lang.String nextString(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONTokener._nextString34142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._nextString34142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _syntaxError34143;
		public virtual global::org.json.JSONException syntaxError(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONTokener._syntaxError34143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONException;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._syntaxError34143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONException;
		}
		internal static global::MonoJavaBridge.MethodId _nextClean34144;
		public virtual char nextClean() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::org.json.JSONTokener._nextClean34144);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._nextClean34144);
		}
		internal static global::MonoJavaBridge.MethodId _nextTo34145;
		public virtual global::java.lang.String nextTo(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONTokener._nextTo34145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._nextTo34145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _nextTo34146;
		public virtual global::java.lang.String nextTo(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONTokener._nextTo34146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._nextTo34146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _skipPast34147;
		public virtual void skipPast(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.json.JSONTokener._skipPast34147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._skipPast34147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _skipTo34148;
		public virtual char skipTo(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::org.json.JSONTokener._skipTo34148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._skipTo34148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _back34149;
		public virtual void back() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.json.JSONTokener._back34149);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._back34149);
		}
		internal static global::MonoJavaBridge.MethodId _dehexchar34150;
		public static int dehexchar(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(org.json.JSONTokener.staticClass, global::org.json.JSONTokener._dehexchar34150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _JSONTokener34151;
		public JSONTokener(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONTokener.staticClass, global::org.json.JSONTokener._JSONTokener34151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.json.JSONTokener.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/json/JSONTokener"));
			global::org.json.JSONTokener._toString34136 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "toString", "()Ljava/lang/String;");
			global::org.json.JSONTokener._next34137 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "next", "(I)Ljava/lang/String;");
			global::org.json.JSONTokener._next34138 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "next", "()C");
			global::org.json.JSONTokener._next34139 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "next", "(C)C");
			global::org.json.JSONTokener._more34140 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "more", "()Z");
			global::org.json.JSONTokener._nextValue34141 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "nextValue", "()Ljava/lang/Object;");
			global::org.json.JSONTokener._nextString34142 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "nextString", "(C)Ljava/lang/String;");
			global::org.json.JSONTokener._syntaxError34143 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "syntaxError", "(Ljava/lang/String;)Lorg/json/JSONException;");
			global::org.json.JSONTokener._nextClean34144 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "nextClean", "()C");
			global::org.json.JSONTokener._nextTo34145 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "nextTo", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.json.JSONTokener._nextTo34146 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "nextTo", "(C)Ljava/lang/String;");
			global::org.json.JSONTokener._skipPast34147 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "skipPast", "(Ljava/lang/String;)V");
			global::org.json.JSONTokener._skipTo34148 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "skipTo", "(C)C");
			global::org.json.JSONTokener._back34149 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "back", "()V");
			global::org.json.JSONTokener._dehexchar34150 = @__env.GetStaticMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "dehexchar", "(C)I");
			global::org.json.JSONTokener._JSONTokener34151 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
