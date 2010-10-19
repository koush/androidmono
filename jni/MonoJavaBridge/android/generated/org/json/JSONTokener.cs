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
		internal static global::MonoJavaBridge.MethodId _toString27327;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONTokener._toString27327)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._toString27327)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _next27328;
		public virtual global::java.lang.String next(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONTokener._next27328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._next27328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _next27329;
		public virtual char next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::org.json.JSONTokener._next27329);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._next27329);
		}
		internal static global::MonoJavaBridge.MethodId _next27330;
		public virtual char next(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::org.json.JSONTokener._next27330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._next27330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _more27331;
		public virtual bool more() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.json.JSONTokener._more27331);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._more27331);
		}
		internal static global::MonoJavaBridge.MethodId _nextValue27332;
		public virtual global::java.lang.Object nextValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONTokener._nextValue27332)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._nextValue27332)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _nextString27333;
		public virtual global::java.lang.String nextString(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONTokener._nextString27333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._nextString27333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _syntaxError27334;
		public virtual global::org.json.JSONException syntaxError(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONTokener._syntaxError27334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONException;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._syntaxError27334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONException;
		}
		internal static global::MonoJavaBridge.MethodId _nextClean27335;
		public virtual char nextClean() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::org.json.JSONTokener._nextClean27335);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._nextClean27335);
		}
		internal static global::MonoJavaBridge.MethodId _nextTo27336;
		public virtual global::java.lang.String nextTo(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONTokener._nextTo27336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._nextTo27336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _nextTo27337;
		public virtual global::java.lang.String nextTo(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONTokener._nextTo27337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._nextTo27337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _skipPast27338;
		public virtual void skipPast(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.json.JSONTokener._skipPast27338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._skipPast27338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _skipTo27339;
		public virtual char skipTo(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::org.json.JSONTokener._skipTo27339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._skipTo27339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _back27340;
		public virtual void back() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.json.JSONTokener._back27340);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._back27340);
		}
		internal static global::MonoJavaBridge.MethodId _dehexchar27341;
		public static int dehexchar(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(org.json.JSONTokener.staticClass, global::org.json.JSONTokener._dehexchar27341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _JSONTokener27342;
		public JSONTokener(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONTokener.staticClass, global::org.json.JSONTokener._JSONTokener27342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.json.JSONTokener.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/json/JSONTokener"));
			global::org.json.JSONTokener._toString27327 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "toString", "()Ljava/lang/String;");
			global::org.json.JSONTokener._next27328 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "next", "(I)Ljava/lang/String;");
			global::org.json.JSONTokener._next27329 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "next", "()C");
			global::org.json.JSONTokener._next27330 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "next", "(C)C");
			global::org.json.JSONTokener._more27331 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "more", "()Z");
			global::org.json.JSONTokener._nextValue27332 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "nextValue", "()Ljava/lang/Object;");
			global::org.json.JSONTokener._nextString27333 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "nextString", "(C)Ljava/lang/String;");
			global::org.json.JSONTokener._syntaxError27334 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "syntaxError", "(Ljava/lang/String;)Lorg/json/JSONException;");
			global::org.json.JSONTokener._nextClean27335 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "nextClean", "()C");
			global::org.json.JSONTokener._nextTo27336 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "nextTo", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.json.JSONTokener._nextTo27337 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "nextTo", "(C)Ljava/lang/String;");
			global::org.json.JSONTokener._skipPast27338 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "skipPast", "(Ljava/lang/String;)V");
			global::org.json.JSONTokener._skipTo27339 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "skipTo", "(C)C");
			global::org.json.JSONTokener._back27340 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "back", "()V");
			global::org.json.JSONTokener._dehexchar27341 = @__env.GetStaticMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "dehexchar", "(C)I");
			global::org.json.JSONTokener._JSONTokener27342 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
