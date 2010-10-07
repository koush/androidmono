namespace java.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class EventObject : java.lang.Object, java.io.Serializable
	{
		internal static global::java.lang.Class staticClass;
		static EventObject()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.util.EventObject), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.util.EventObject(@__env);
			}
		}
		protected EventObject(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString13680;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.EventObject._toString13680));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.EventObject.staticClass, global::java.util.EventObject._toString13680));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSource13681;
		public virtual global::java.lang.Object getSource() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.EventObject._getSource13681));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.EventObject.staticClass, global::java.util.EventObject._getSource13681));
		}
		internal static global::net.sf.jni4net.jni.MethodId _EventObject13682;
		public EventObject(java.lang.Object arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.EventObject.staticClass, global::java.util.EventObject._EventObject13682, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.util.EventObject.staticClass = @__class;
			global::java.util.EventObject._toString13680 = @__env.GetMethodID(global::java.util.EventObject.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.EventObject._getSource13681 = @__env.GetMethodID(global::java.util.EventObject.staticClass, "getSource", "()Ljava/lang/Object;");
			global::java.util.EventObject._EventObject13682 = @__env.GetMethodID(global::java.util.EventObject.staticClass, "<init>", "(Ljava/lang/Object;)V");
		}
	}
}
