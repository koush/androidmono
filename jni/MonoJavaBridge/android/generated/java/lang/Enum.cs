namespace java.lang
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.lang.Enum_))]
	public abstract partial class Enum : java.lang.Object, Comparable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Enum()
		{
			InitJNI();
		}
		protected Enum(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _name14490;
		public virtual global::java.lang.String name() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Enum._name14490)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Enum.staticClass, global::java.lang.Enum._name14490)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _finalize14491;
		protected sealed override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Enum._finalize14491);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Enum.staticClass, global::java.lang.Enum._finalize14491);
		}
		internal static global::MonoJavaBridge.MethodId _equals14492;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Enum._equals14492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Enum.staticClass, global::java.lang.Enum._equals14492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString14493;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Enum._toString14493)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Enum.staticClass, global::java.lang.Enum._toString14493)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode14494;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Enum._hashCode14494);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Enum.staticClass, global::java.lang.Enum._hashCode14494);
		}
		internal static global::MonoJavaBridge.MethodId _clone14495;
		protected sealed override global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Enum._clone14495)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Enum.staticClass, global::java.lang.Enum._clone14495)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _compareTo14496;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Enum._compareTo14496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Enum.staticClass, global::java.lang.Enum._compareTo14496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo14497;
		public virtual int compareTo(java.lang.Enum arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Enum._compareTo14497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Enum.staticClass, global::java.lang.Enum._compareTo14497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueOf14498;
		public static global::java.lang.Enum valueOf(java.lang.Class arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Enum.staticClass, global::java.lang.Enum._valueOf14498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Enum;
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaringClass14499;
		public virtual global::java.lang.Class getDeclaringClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Enum._getDeclaringClass14499)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Enum.staticClass, global::java.lang.Enum._getDeclaringClass14499)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _ordinal14500;
		public virtual int ordinal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Enum._ordinal14500);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Enum.staticClass, global::java.lang.Enum._ordinal14500);
		}
		internal static global::MonoJavaBridge.MethodId _Enum14501;
		protected Enum(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Enum.staticClass, global::java.lang.Enum._Enum14501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Enum.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Enum"));
			global::java.lang.Enum._name14490 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "name", "()Ljava/lang/String;");
			global::java.lang.Enum._finalize14491 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "finalize", "()V");
			global::java.lang.Enum._equals14492 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Enum._toString14493 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Enum._hashCode14494 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "hashCode", "()I");
			global::java.lang.Enum._clone14495 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.lang.Enum._compareTo14496 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Enum._compareTo14497 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "compareTo", "(Ljava/lang/Enum;)I");
			global::java.lang.Enum._valueOf14498 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Enum.staticClass, "valueOf", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;");
			global::java.lang.Enum._getDeclaringClass14499 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "getDeclaringClass", "()Ljava/lang/Class;");
			global::java.lang.Enum._ordinal14500 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "ordinal", "()I");
			global::java.lang.Enum._Enum14501 = @__env.GetMethodIDNoThrow(global::java.lang.Enum.staticClass, "<init>", "(Ljava/lang/String;I)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.Enum))]
	public sealed partial class Enum_ : java.lang.Enum
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Enum_()
		{
			InitJNI();
		}
		internal Enum_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Enum_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Enum"));
		}
	}
}
