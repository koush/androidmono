namespace org.json
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JSONStringer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static JSONStringer()
		{
			InitJNI();
		}
		protected JSONStringer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _value34007;
		public virtual global::org.json.JSONStringer value(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONStringer._value34007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONStringer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONStringer.staticClass, global::org.json.JSONStringer._value34007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONStringer;
		}
		internal static global::MonoJavaBridge.MethodId _value34008;
		public virtual global::org.json.JSONStringer value(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONStringer._value34008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONStringer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONStringer.staticClass, global::org.json.JSONStringer._value34008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONStringer;
		}
		internal static global::MonoJavaBridge.MethodId _value34009;
		public virtual global::org.json.JSONStringer value(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONStringer._value34009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONStringer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONStringer.staticClass, global::org.json.JSONStringer._value34009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONStringer;
		}
		internal static global::MonoJavaBridge.MethodId _value34010;
		public virtual global::org.json.JSONStringer value(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONStringer._value34010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONStringer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONStringer.staticClass, global::org.json.JSONStringer._value34010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONStringer;
		}
		internal static global::MonoJavaBridge.MethodId _toString34011;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONStringer._toString34011)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONStringer.staticClass, global::org.json.JSONStringer._toString34011)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _array34012;
		public virtual global::org.json.JSONStringer array() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONStringer._array34012)) as org.json.JSONStringer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONStringer.staticClass, global::org.json.JSONStringer._array34012)) as org.json.JSONStringer;
		}
		internal static global::MonoJavaBridge.MethodId _key34013;
		public virtual global::org.json.JSONStringer key(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONStringer._key34013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONStringer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONStringer.staticClass, global::org.json.JSONStringer._key34013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONStringer;
		}
		internal static global::MonoJavaBridge.MethodId _object34014;
		public virtual global::org.json.JSONStringer @object() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONStringer._object34014)) as org.json.JSONStringer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONStringer.staticClass, global::org.json.JSONStringer._object34014)) as org.json.JSONStringer;
		}
		internal static global::MonoJavaBridge.MethodId _endArray34015;
		public virtual global::org.json.JSONStringer endArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONStringer._endArray34015)) as org.json.JSONStringer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONStringer.staticClass, global::org.json.JSONStringer._endArray34015)) as org.json.JSONStringer;
		}
		internal static global::MonoJavaBridge.MethodId _endObject34016;
		public virtual global::org.json.JSONStringer endObject() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.json.JSONStringer._endObject34016)) as org.json.JSONStringer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.json.JSONStringer.staticClass, global::org.json.JSONStringer._endObject34016)) as org.json.JSONStringer;
		}
		internal static global::MonoJavaBridge.MethodId _JSONStringer34017;
		public JSONStringer()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONStringer.staticClass, global::org.json.JSONStringer._JSONStringer34017);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.json.JSONStringer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/json/JSONStringer"));
			global::org.json.JSONStringer._value34007 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "value", "(Ljava/lang/Object;)Lorg/json/JSONStringer;");
			global::org.json.JSONStringer._value34008 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "value", "(Z)Lorg/json/JSONStringer;");
			global::org.json.JSONStringer._value34009 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "value", "(D)Lorg/json/JSONStringer;");
			global::org.json.JSONStringer._value34010 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "value", "(J)Lorg/json/JSONStringer;");
			global::org.json.JSONStringer._toString34011 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "toString", "()Ljava/lang/String;");
			global::org.json.JSONStringer._array34012 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "array", "()Lorg/json/JSONStringer;");
			global::org.json.JSONStringer._key34013 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "key", "(Ljava/lang/String;)Lorg/json/JSONStringer;");
			global::org.json.JSONStringer._object34014 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "@object", "()Lorg/json/JSONStringer;");
			global::org.json.JSONStringer._endArray34015 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "endArray", "()Lorg/json/JSONStringer;");
			global::org.json.JSONStringer._endObject34016 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "endObject", "()Lorg/json/JSONStringer;");
			global::org.json.JSONStringer._JSONStringer34017 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "<init>", "()V");
		}
	}
}
