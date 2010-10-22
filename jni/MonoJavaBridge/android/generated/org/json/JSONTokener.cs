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
		internal static global::MonoJavaBridge.MethodId _toString34018;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONTokener._toString34018)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._toString34018)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _next34019;
		public virtual global::java.lang.String next(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONTokener._next34019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._next34019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _next34020;
		public virtual char next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::org.json.JSONTokener._next34020);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._next34020);
		}
		internal static global::MonoJavaBridge.MethodId _next34021;
		public virtual char next(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::org.json.JSONTokener._next34021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._next34021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _more34022;
		public virtual bool more() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.json.JSONTokener._more34022);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._more34022);
		}
		internal static global::MonoJavaBridge.MethodId _nextValue34023;
		public virtual global::java.lang.Object nextValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONTokener._nextValue34023)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._nextValue34023)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _nextString34024;
		public virtual global::java.lang.String nextString(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONTokener._nextString34024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._nextString34024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _syntaxError34025;
		public virtual global::org.json.JSONException syntaxError(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONTokener._syntaxError34025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONException;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._syntaxError34025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONException;
		}
		internal static global::MonoJavaBridge.MethodId _nextClean34026;
		public virtual char nextClean() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::org.json.JSONTokener._nextClean34026);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._nextClean34026);
		}
		internal static global::MonoJavaBridge.MethodId _nextTo34027;
		public virtual global::java.lang.String nextTo(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONTokener._nextTo34027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._nextTo34027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _nextTo34028;
		public virtual global::java.lang.String nextTo(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONTokener._nextTo34028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._nextTo34028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _skipPast34029;
		public virtual void skipPast(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.json.JSONTokener._skipPast34029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._skipPast34029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _skipTo34030;
		public virtual char skipTo(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::org.json.JSONTokener._skipTo34030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._skipTo34030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _back34031;
		public virtual void back() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.json.JSONTokener._back34031);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._back34031);
		}
		internal static global::MonoJavaBridge.MethodId _dehexchar34032;
		public static int dehexchar(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(org.json.JSONTokener.staticClass, global::org.json.JSONTokener._dehexchar34032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _JSONTokener34033;
		public JSONTokener(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONTokener.staticClass, global::org.json.JSONTokener._JSONTokener34033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.json.JSONTokener.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/json/JSONTokener"));
			global::org.json.JSONTokener._toString34018 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "toString", "()Ljava/lang/String;");
			global::org.json.JSONTokener._next34019 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "next", "(I)Ljava/lang/String;");
			global::org.json.JSONTokener._next34020 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "next", "()C");
			global::org.json.JSONTokener._next34021 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "next", "(C)C");
			global::org.json.JSONTokener._more34022 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "more", "()Z");
			global::org.json.JSONTokener._nextValue34023 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "nextValue", "()Ljava/lang/Object;");
			global::org.json.JSONTokener._nextString34024 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "nextString", "(C)Ljava/lang/String;");
			global::org.json.JSONTokener._syntaxError34025 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "syntaxError", "(Ljava/lang/String;)Lorg/json/JSONException;");
			global::org.json.JSONTokener._nextClean34026 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "nextClean", "()C");
			global::org.json.JSONTokener._nextTo34027 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "nextTo", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.json.JSONTokener._nextTo34028 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "nextTo", "(C)Ljava/lang/String;");
			global::org.json.JSONTokener._skipPast34029 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "skipPast", "(Ljava/lang/String;)V");
			global::org.json.JSONTokener._skipTo34030 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "skipTo", "(C)C");
			global::org.json.JSONTokener._back34031 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "back", "()V");
			global::org.json.JSONTokener._dehexchar34032 = @__env.GetStaticMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "dehexchar", "(C)I");
			global::org.json.JSONTokener._JSONTokener34033 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
