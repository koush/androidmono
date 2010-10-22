namespace java.io
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.io.Externalizable_))]
	public partial interface Externalizable : Serializable
	{
		void writeExternal(java.io.ObjectOutput arg0);
		void readExternal(java.io.ObjectInput arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.Externalizable))]
	public sealed partial class Externalizable_ : java.lang.Object, Externalizable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Externalizable_()
		{
			InitJNI();
		}
		internal Externalizable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeExternal18832;
		 void java.io.Externalizable.writeExternal(java.io.ObjectOutput arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Externalizable_._writeExternal18832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Externalizable_.staticClass, global::java.io.Externalizable_._writeExternal18832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readExternal18833;
		 void java.io.Externalizable.readExternal(java.io.ObjectInput arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Externalizable_._readExternal18833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Externalizable_.staticClass, global::java.io.Externalizable_._readExternal18833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.Externalizable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/Externalizable"));
			global::java.io.Externalizable_._writeExternal18832 = @__env.GetMethodIDNoThrow(global::java.io.Externalizable_.staticClass, "writeExternal", "(Ljava/io/ObjectOutput;)V");
			global::java.io.Externalizable_._readExternal18833 = @__env.GetMethodIDNoThrow(global::java.io.Externalizable_.staticClass, "readExternal", "(Ljava/io/ObjectInput;)V");
		}
	}
}
