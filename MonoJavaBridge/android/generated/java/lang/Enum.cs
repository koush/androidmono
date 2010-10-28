namespace java.lang
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.lang.Enum_))]
	public abstract partial class Enum : java.lang.Object, Comparable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Enum(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _name20114;
		public virtual global::java.lang.String name()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Enum._name20114)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Enum.staticClass, global::java.lang.Enum._name20114)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _finalize20115;
		protected sealed override void finalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Enum._finalize20115);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Enum.staticClass, global::java.lang.Enum._finalize20115);
		}
		internal static global::MonoJavaBridge.MethodId _equals20116;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Enum._equals20116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Enum.staticClass, global::java.lang.Enum._equals20116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20117;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Enum._toString20117)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Enum.staticClass, global::java.lang.Enum._toString20117)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20118;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Enum._hashCode20118);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Enum.staticClass, global::java.lang.Enum._hashCode20118);
		}
		internal static global::MonoJavaBridge.MethodId _clone20119;
		protected sealed override global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Enum._clone20119)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Enum.staticClass, global::java.lang.Enum._clone20119)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _compareTo20120;
		public virtual int compareTo(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Enum._compareTo20120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Enum.staticClass, global::java.lang.Enum._compareTo20120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo20121;
		public virtual int compareTo(java.lang.Enum arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Enum._compareTo20121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Enum.staticClass, global::java.lang.Enum._compareTo20121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20122;
		public static global::java.lang.Enum valueOf(java.lang.Class arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Enum.staticClass, global::java.lang.Enum._valueOf20122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Enum;
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaringClass20123;
		public virtual global::java.lang.Class getDeclaringClass()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Enum._getDeclaringClass20123)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Enum.staticClass, global::java.lang.Enum._getDeclaringClass20123)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _ordinal20124;
		public virtual int ordinal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Enum._ordinal20124);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Enum.staticClass, global::java.lang.Enum._ordinal20124);
		}
		internal static global::MonoJavaBridge.MethodId _Enum20125;
		protected Enum(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Enum.staticClass, global::java.lang.Enum._Enum20125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static Enum()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Enum.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Enum"));
			global::java.lang.Enum._name20114 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "name", "()Ljava/lang/String;");
			global::java.lang.Enum._finalize20115 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "finalize", "()V");
			global::java.lang.Enum._equals20116 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Enum._toString20117 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Enum._hashCode20118 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "hashCode", "()I");
			global::java.lang.Enum._clone20119 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.lang.Enum._compareTo20120 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Enum._compareTo20121 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "compareTo", "(Ljava/lang/Enum;)I");
			global::java.lang.Enum._valueOf20122 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Enum.staticClass, "valueOf", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;");
			global::java.lang.Enum._getDeclaringClass20123 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "getDeclaringClass", "()Ljava/lang/Class;");
			global::java.lang.Enum._ordinal20124 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "ordinal", "()I");
			global::java.lang.Enum._Enum20125 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "<init>", "(Ljava/lang/String;I)V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.Enum))]
	internal sealed partial class Enum_ : java.lang.Enum
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Enum_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static Enum_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Enum_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Enum"));
		}
		internal static void InitJNI()
		{
		}
	}
}
