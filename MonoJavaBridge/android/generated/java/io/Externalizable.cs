namespace java.io
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.io.Externalizable_))]
	public partial interface Externalizable : Serializable
	{
		void writeExternal(java.io.ObjectOutput arg0);
		void readExternal(java.io.ObjectInput arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.Externalizable))]
	internal sealed partial class Externalizable_ : java.lang.Object, Externalizable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Externalizable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void java.io.Externalizable.writeExternal(java.io.ObjectOutput arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.Externalizable_.staticClass, "writeExternal", "(Ljava/io/ObjectOutput;)V", ref global::java.io.Externalizable_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void java.io.Externalizable.readExternal(java.io.ObjectInput arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.Externalizable_.staticClass, "readExternal", "(Ljava/io/ObjectInput;)V", ref global::java.io.Externalizable_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Externalizable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.Externalizable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/Externalizable"));
		}
	}
}
