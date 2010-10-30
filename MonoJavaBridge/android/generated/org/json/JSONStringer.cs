namespace org.json
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JSONStringer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected JSONStringer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _value34126;
		public virtual global::org.json.JSONStringer value(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONStringer.staticClass, global::org.json.JSONStringer._value34126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONStringer;
		}
		internal static global::MonoJavaBridge.MethodId _value34127;
		public virtual global::org.json.JSONStringer value(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONStringer.staticClass, global::org.json.JSONStringer._value34127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONStringer;
		}
		internal static global::MonoJavaBridge.MethodId _value34128;
		public virtual global::org.json.JSONStringer value(double arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONStringer.staticClass, global::org.json.JSONStringer._value34128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONStringer;
		}
		internal static global::MonoJavaBridge.MethodId _value34129;
		public virtual global::org.json.JSONStringer value(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONStringer.staticClass, global::org.json.JSONStringer._value34129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONStringer;
		}
		internal static global::MonoJavaBridge.MethodId _toString34130;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONStringer.staticClass, global::org.json.JSONStringer._toString34130)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _array34131;
		public virtual global::org.json.JSONStringer array()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONStringer.staticClass, global::org.json.JSONStringer._array34131)) as org.json.JSONStringer;
		}
		internal static global::MonoJavaBridge.MethodId _key34132;
		public virtual global::org.json.JSONStringer key(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONStringer.staticClass, global::org.json.JSONStringer._key34132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.json.JSONStringer;
		}
		internal static global::MonoJavaBridge.MethodId _object34133;
		public virtual global::org.json.JSONStringer @object()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONStringer.staticClass, global::org.json.JSONStringer._object34133)) as org.json.JSONStringer;
		}
		internal static global::MonoJavaBridge.MethodId _endArray34134;
		public virtual global::org.json.JSONStringer endArray()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONStringer.staticClass, global::org.json.JSONStringer._endArray34134)) as org.json.JSONStringer;
		}
		internal static global::MonoJavaBridge.MethodId _endObject34135;
		public virtual global::org.json.JSONStringer endObject()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONStringer.staticClass, global::org.json.JSONStringer._endObject34135)) as org.json.JSONStringer;
		}
		internal static global::MonoJavaBridge.MethodId _JSONStringer34136;
		public JSONStringer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONStringer.staticClass, global::org.json.JSONStringer._JSONStringer34136);
			Init(@__env, handle);
		}
		static JSONStringer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.json.JSONStringer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/json/JSONStringer"));
			global::org.json.JSONStringer._value34126 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "value", "(Ljava/lang/Object;)Lorg/json/JSONStringer;");
			global::org.json.JSONStringer._value34127 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "value", "(Z)Lorg/json/JSONStringer;");
			global::org.json.JSONStringer._value34128 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "value", "(D)Lorg/json/JSONStringer;");
			global::org.json.JSONStringer._value34129 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "value", "(J)Lorg/json/JSONStringer;");
			global::org.json.JSONStringer._toString34130 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "toString", "()Ljava/lang/String;");
			global::org.json.JSONStringer._array34131 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "array", "()Lorg/json/JSONStringer;");
			global::org.json.JSONStringer._key34132 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "key", "(Ljava/lang/String;)Lorg/json/JSONStringer;");
			global::org.json.JSONStringer._object34133 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "@object", "()Lorg/json/JSONStringer;");
			global::org.json.JSONStringer._endArray34134 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "endArray", "()Lorg/json/JSONStringer;");
			global::org.json.JSONStringer._endObject34135 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "endObject", "()Lorg/json/JSONStringer;");
			global::org.json.JSONStringer._JSONStringer34136 = @__env.GetMethodIDNoThrow(global::org.json.JSONStringer.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
