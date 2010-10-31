namespace java.nio
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.ShortBuffer_))]
	public abstract partial class ShortBuffer : java.nio.Buffer, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ShortBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract short get();
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.nio.ShortBuffer get(short[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ShortBuffer.staticClass, "get", "([S)Ljava/nio/ShortBuffer;", ref global::java.nio.ShortBuffer._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ShortBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.nio.ShortBuffer get(short[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ShortBuffer.staticClass, "get", "([SII)Ljava/nio/ShortBuffer;", ref global::java.nio.ShortBuffer._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.nio.ShortBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract short get(int arg0);
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.nio.ShortBuffer put(java.nio.ShortBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ShortBuffer.staticClass, "put", "(Ljava/nio/ShortBuffer;)Ljava/nio/ShortBuffer;", ref global::java.nio.ShortBuffer._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ShortBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract global::java.nio.ShortBuffer put(short arg0);
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract global::java.nio.ShortBuffer put(int arg0, short arg1);
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.nio.ShortBuffer put(short[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ShortBuffer.staticClass, "put", "([SII)Ljava/nio/ShortBuffer;", ref global::java.nio.ShortBuffer._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.nio.ShortBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.nio.ShortBuffer put(short[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ShortBuffer.staticClass, "put", "([S)Ljava/nio/ShortBuffer;", ref global::java.nio.ShortBuffer._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ShortBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.ShortBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.nio.ShortBuffer._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.ShortBuffer.staticClass, "toString", "()Ljava/lang/String;", ref global::java.nio.ShortBuffer._m10) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.ShortBuffer.staticClass, "hashCode", "()I", ref global::java.nio.ShortBuffer._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.ShortBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.nio.ShortBuffer._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual int compareTo(java.nio.ShortBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.ShortBuffer.staticClass, "compareTo", "(Ljava/nio/ShortBuffer;)I", ref global::java.nio.ShortBuffer._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public abstract bool isDirect();
		private static global::MonoJavaBridge.MethodId _m15;
		public sealed override bool hasArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.ShortBuffer.staticClass, "hasArray", "()Z", ref global::java.nio.ShortBuffer._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override global::java.lang.Object array()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ShortBuffer.staticClass, "array", "()Ljava/lang/Object;", ref global::java.nio.ShortBuffer._m16) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public sealed override int arrayOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.ShortBuffer.staticClass, "arrayOffset", "()I", ref global::java.nio.ShortBuffer._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static global::java.nio.ShortBuffer wrap(short[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.ShortBuffer._m18.native == global::System.IntPtr.Zero)
				global::java.nio.ShortBuffer._m18 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "wrap", "([SII)Ljava/nio/ShortBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ShortBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static global::java.nio.ShortBuffer wrap(short[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.ShortBuffer._m19.native == global::System.IntPtr.Zero)
				global::java.nio.ShortBuffer._m19 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "wrap", "([S)Ljava/nio/ShortBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static global::java.nio.ShortBuffer allocate(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.ShortBuffer._m20.native == global::System.IntPtr.Zero)
				global::java.nio.ShortBuffer._m20 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "allocate", "(I)Ljava/nio/ShortBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public abstract global::java.nio.ShortBuffer duplicate();
		private static global::MonoJavaBridge.MethodId _m22;
		public abstract global::java.nio.ShortBuffer slice();
		private static global::MonoJavaBridge.MethodId _m23;
		public abstract global::java.nio.ShortBuffer asReadOnlyBuffer();
		private static global::MonoJavaBridge.MethodId _m24;
		public abstract global::java.nio.ShortBuffer compact();
		private static global::MonoJavaBridge.MethodId _m25;
		public abstract global::java.nio.ByteOrder order();
		static ShortBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.ShortBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/ShortBuffer"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.ShortBuffer))]
	internal sealed partial class ShortBuffer_ : java.nio.ShortBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ShortBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override short get()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.nio.ShortBuffer_.staticClass, "get", "()S", ref global::java.nio.ShortBuffer_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override short get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.nio.ShortBuffer_.staticClass, "get", "(I)S", ref global::java.nio.ShortBuffer_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.nio.ShortBuffer put(short arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ShortBuffer_.staticClass, "put", "(S)Ljava/nio/ShortBuffer;", ref global::java.nio.ShortBuffer_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ShortBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.nio.ShortBuffer put(int arg0, short arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ShortBuffer_.staticClass, "put", "(IS)Ljava/nio/ShortBuffer;", ref global::java.nio.ShortBuffer_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.ShortBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool isDirect()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.ShortBuffer_.staticClass, "isDirect", "()Z", ref global::java.nio.ShortBuffer_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::java.nio.ShortBuffer duplicate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ShortBuffer_.staticClass, "duplicate", "()Ljava/nio/ShortBuffer;", ref global::java.nio.ShortBuffer_._m5) as java.nio.ShortBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::java.nio.ShortBuffer slice()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ShortBuffer_.staticClass, "slice", "()Ljava/nio/ShortBuffer;", ref global::java.nio.ShortBuffer_._m6) as java.nio.ShortBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.nio.ShortBuffer asReadOnlyBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ShortBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/ShortBuffer;", ref global::java.nio.ShortBuffer_._m7) as java.nio.ShortBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override global::java.nio.ShortBuffer compact()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ShortBuffer_.staticClass, "compact", "()Ljava/nio/ShortBuffer;", ref global::java.nio.ShortBuffer_._m8) as java.nio.ShortBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override global::java.nio.ByteOrder order()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.nio.ByteOrder>(this, global::java.nio.ShortBuffer_.staticClass, "order", "()Ljava/nio/ByteOrder;", ref global::java.nio.ShortBuffer_._m9) as java.nio.ByteOrder;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override bool isReadOnly()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.ShortBuffer_.staticClass, "isReadOnly", "()Z", ref global::java.nio.ShortBuffer_._m10);
		}
		static ShortBuffer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.ShortBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/ShortBuffer"));
		}
	}
}
