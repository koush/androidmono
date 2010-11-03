namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ObjectStreamField : java.lang.Object, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ObjectStreamField(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.ObjectStreamField.staticClass, "toString", "()Ljava/lang/String;", ref global::java.io.ObjectStreamField._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool isPrimitive()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.ObjectStreamField.staticClass, "isPrimitive", "()Z", ref global::java.io.ObjectStreamField._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectStreamField.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.io.ObjectStreamField._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.ObjectStreamField.staticClass, "getName", "()Ljava/lang/String;", ref global::java.io.ObjectStreamField._m3) as java.lang.String;
		}
		public new global::java.lang.Class Type
		{
			get
			{
				return getType();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.Class getType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.io.ObjectStreamField.staticClass, "getType", "()Ljava/lang/Class;", ref global::java.io.ObjectStreamField._m4) as java.lang.Class;
		}
		public new char TypeCode
		{
			get
			{
				return getTypeCode();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual char getTypeCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.io.ObjectStreamField.staticClass, "getTypeCode", "()C", ref global::java.io.ObjectStreamField._m5);
		}
		public new global::java.lang.String TypeString
		{
			get
			{
				return getTypeString();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.lang.String getTypeString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.ObjectStreamField.staticClass, "getTypeString", "()Ljava/lang/String;", ref global::java.io.ObjectStreamField._m6) as java.lang.String;
		}
		public new int Offset
		{
			get
			{
				return getOffset();
			}
			set
			{
				setOffset(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int getOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectStreamField.staticClass, "getOffset", "()I", ref global::java.io.ObjectStreamField._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected virtual void setOffset(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectStreamField.staticClass, "setOffset", "(I)V", ref global::java.io.ObjectStreamField._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool isUnshared()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.ObjectStreamField.staticClass, "isUnshared", "()Z", ref global::java.io.ObjectStreamField._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public ObjectStreamField(java.lang.String arg0, java.lang.Class arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectStreamField._m10.native == global::System.IntPtr.Zero)
				global::java.io.ObjectStreamField._m10 = @__env.GetMethodIDNoThrow(global::java.io.ObjectStreamField.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Class;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectStreamField.staticClass, global::java.io.ObjectStreamField._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public ObjectStreamField(java.lang.String arg0, java.lang.Class arg1, bool arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectStreamField._m11.native == global::System.IntPtr.Zero)
				global::java.io.ObjectStreamField._m11 = @__env.GetMethodIDNoThrow(global::java.io.ObjectStreamField.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Class;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectStreamField.staticClass, global::java.io.ObjectStreamField._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static ObjectStreamField()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ObjectStreamField.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectStreamField"));
		}
	}
}
