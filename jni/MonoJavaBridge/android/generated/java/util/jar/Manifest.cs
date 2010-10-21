namespace java.util.jar
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Manifest : java.lang.Object, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Manifest()
		{
			InitJNI();
		}
		protected Manifest(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals27767;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.jar.Manifest._equals27767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.jar.Manifest.staticClass, global::java.util.jar.Manifest._equals27767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode27768;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.jar.Manifest._hashCode27768);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.jar.Manifest.staticClass, global::java.util.jar.Manifest._hashCode27768);
		}
		internal static global::MonoJavaBridge.MethodId _clone27769;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Manifest._clone27769)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Manifest.staticClass, global::java.util.jar.Manifest._clone27769)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear27770;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.jar.Manifest._clear27770);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.jar.Manifest.staticClass, global::java.util.jar.Manifest._clear27770);
		}
		internal static global::MonoJavaBridge.MethodId _write27771;
		public virtual void write(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.jar.Manifest._write27771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.jar.Manifest.staticClass, global::java.util.jar.Manifest._write27771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read27772;
		public virtual void read(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.jar.Manifest._read27772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.jar.Manifest.staticClass, global::java.util.jar.Manifest._read27772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes27773;
		public virtual global::java.util.jar.Attributes getAttributes(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Manifest._getAttributes27773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.jar.Attributes;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Manifest.staticClass, global::java.util.jar.Manifest._getAttributes27773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.jar.Attributes;
		}
		public new global::java.util.jar.Attributes MainAttributes
		{
			get
			{
				return getMainAttributes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMainAttributes27774;
		public virtual global::java.util.jar.Attributes getMainAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Manifest._getMainAttributes27774)) as java.util.jar.Attributes;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Manifest.staticClass, global::java.util.jar.Manifest._getMainAttributes27774)) as java.util.jar.Attributes;
		}
		public new global::java.util.Map Entries
		{
			get
			{
				return getEntries();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEntries27775;
		public virtual global::java.util.Map getEntries() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.jar.Manifest._getEntries27775)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.jar.Manifest.staticClass, global::java.util.jar.Manifest._getEntries27775)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _Manifest27776;
		public Manifest(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.Manifest.staticClass, global::java.util.jar.Manifest._Manifest27776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Manifest27777;
		public Manifest(java.util.jar.Manifest arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.Manifest.staticClass, global::java.util.jar.Manifest._Manifest27777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Manifest27778;
		public Manifest()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.jar.Manifest.staticClass, global::java.util.jar.Manifest._Manifest27778);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.jar.Manifest.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/jar/Manifest"));
			global::java.util.jar.Manifest._equals27767 = @__env.GetMethodIDNoThrow(global::java.util.jar.Manifest.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.jar.Manifest._hashCode27768 = @__env.GetMethodIDNoThrow(global::java.util.jar.Manifest.staticClass, "hashCode", "()I");
			global::java.util.jar.Manifest._clone27769 = @__env.GetMethodIDNoThrow(global::java.util.jar.Manifest.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.jar.Manifest._clear27770 = @__env.GetMethodIDNoThrow(global::java.util.jar.Manifest.staticClass, "clear", "()V");
			global::java.util.jar.Manifest._write27771 = @__env.GetMethodIDNoThrow(global::java.util.jar.Manifest.staticClass, "write", "(Ljava/io/OutputStream;)V");
			global::java.util.jar.Manifest._read27772 = @__env.GetMethodIDNoThrow(global::java.util.jar.Manifest.staticClass, "read", "(Ljava/io/InputStream;)V");
			global::java.util.jar.Manifest._getAttributes27773 = @__env.GetMethodIDNoThrow(global::java.util.jar.Manifest.staticClass, "getAttributes", "(Ljava/lang/String;)Ljava/util/jar/Attributes;");
			global::java.util.jar.Manifest._getMainAttributes27774 = @__env.GetMethodIDNoThrow(global::java.util.jar.Manifest.staticClass, "getMainAttributes", "()Ljava/util/jar/Attributes;");
			global::java.util.jar.Manifest._getEntries27775 = @__env.GetMethodIDNoThrow(global::java.util.jar.Manifest.staticClass, "getEntries", "()Ljava/util/Map;");
			global::java.util.jar.Manifest._Manifest27776 = @__env.GetMethodIDNoThrow(global::java.util.jar.Manifest.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::java.util.jar.Manifest._Manifest27777 = @__env.GetMethodIDNoThrow(global::java.util.jar.Manifest.staticClass, "<init>", "(Ljava/util/jar/Manifest;)V");
			global::java.util.jar.Manifest._Manifest27778 = @__env.GetMethodIDNoThrow(global::java.util.jar.Manifest.staticClass, "<init>", "()V");
		}
	}
}
