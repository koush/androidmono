namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EventObject : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EventObject(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString26175;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.EventObject._toString26175)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.EventObject.staticClass, global::java.util.EventObject._toString26175)) as java.lang.String;
		}
		public new global::java.lang.Object Source
		{
			get
			{
				return getSource();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSource26176;
		public virtual global::java.lang.Object getSource()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.EventObject._getSource26176)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.EventObject.staticClass, global::java.util.EventObject._getSource26176)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _EventObject26177;
		public EventObject(java.lang.Object arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.EventObject.staticClass, global::java.util.EventObject._EventObject26177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static EventObject()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.EventObject.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/EventObject"));
			global::java.util.EventObject._toString26175 = @__env.GetMethodIDNoThrow(global::java.util.EventObject.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.EventObject._getSource26176 = @__env.GetMethodIDNoThrow(global::java.util.EventObject.staticClass, "getSource", "()Ljava/lang/Object;");
			global::java.util.EventObject._EventObject26177 = @__env.GetMethodIDNoThrow(global::java.util.EventObject.staticClass, "<init>", "(Ljava/lang/Object;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
