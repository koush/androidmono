namespace java.nio
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.IntBuffer_))]
	public abstract partial class IntBuffer : java.nio.Buffer, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IntBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract int get();
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.nio.IntBuffer get(int[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.IntBuffer.staticClass, "get", "([I)Ljava/nio/IntBuffer;", ref global::java.nio.IntBuffer._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.IntBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.nio.IntBuffer get(int[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.IntBuffer.staticClass, "get", "([III)Ljava/nio/IntBuffer;", ref global::java.nio.IntBuffer._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.nio.IntBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract int get(int arg0);
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.nio.IntBuffer put(java.nio.IntBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.IntBuffer.staticClass, "put", "(Ljava/nio/IntBuffer;)Ljava/nio/IntBuffer;", ref global::java.nio.IntBuffer._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.IntBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract global::java.nio.IntBuffer put(int arg0);
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract global::java.nio.IntBuffer put(int arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.nio.IntBuffer put(int[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.IntBuffer.staticClass, "put", "([III)Ljava/nio/IntBuffer;", ref global::java.nio.IntBuffer._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.nio.IntBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.nio.IntBuffer put(int[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.IntBuffer.staticClass, "put", "([I)Ljava/nio/IntBuffer;", ref global::java.nio.IntBuffer._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.IntBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.IntBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.nio.IntBuffer._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.IntBuffer.staticClass, "toString", "()Ljava/lang/String;", ref global::java.nio.IntBuffer._m10) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.IntBuffer.staticClass, "hashCode", "()I", ref global::java.nio.IntBuffer._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.IntBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.nio.IntBuffer._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual int compareTo(java.nio.IntBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.IntBuffer.staticClass, "compareTo", "(Ljava/nio/IntBuffer;)I", ref global::java.nio.IntBuffer._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public abstract bool isDirect();
		private static global::MonoJavaBridge.MethodId _m15;
		public sealed override bool hasArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.IntBuffer.staticClass, "hasArray", "()Z", ref global::java.nio.IntBuffer._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override global::java.lang.Object array()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.IntBuffer.staticClass, "array", "()Ljava/lang/Object;", ref global::java.nio.IntBuffer._m16) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public sealed override int arrayOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.IntBuffer.staticClass, "arrayOffset", "()I", ref global::java.nio.IntBuffer._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static global::java.nio.IntBuffer wrap(int[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.IntBuffer._m18.native == global::System.IntPtr.Zero)
				global::java.nio.IntBuffer._m18 = @__env.GetStaticMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "wrap", "([III)Ljava/nio/IntBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.IntBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static global::java.nio.IntBuffer wrap(int[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.IntBuffer._m19.native == global::System.IntPtr.Zero)
				global::java.nio.IntBuffer._m19 = @__env.GetStaticMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "wrap", "([I)Ljava/nio/IntBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static global::java.nio.IntBuffer allocate(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.IntBuffer._m20.native == global::System.IntPtr.Zero)
				global::java.nio.IntBuffer._m20 = @__env.GetStaticMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "allocate", "(I)Ljava/nio/IntBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public abstract global::java.nio.IntBuffer duplicate();
		private static global::MonoJavaBridge.MethodId _m22;
		public abstract global::java.nio.IntBuffer slice();
		private static global::MonoJavaBridge.MethodId _m23;
		public abstract global::java.nio.IntBuffer asReadOnlyBuffer();
		private static global::MonoJavaBridge.MethodId _m24;
		public abstract global::java.nio.IntBuffer compact();
		private static global::MonoJavaBridge.MethodId _m25;
		public abstract global::java.nio.ByteOrder order();
		static IntBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.IntBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/IntBuffer"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.IntBuffer))]
	internal sealed partial class IntBuffer_ : java.nio.IntBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal IntBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override int get()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.IntBuffer_.staticClass, "get", "()I", ref global::java.nio.IntBuffer_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.IntBuffer_.staticClass, "get", "(I)I", ref global::java.nio.IntBuffer_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.nio.IntBuffer put(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.IntBuffer_.staticClass, "put", "(I)Ljava/nio/IntBuffer;", ref global::java.nio.IntBuffer_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.IntBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.nio.IntBuffer put(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.IntBuffer_.staticClass, "put", "(II)Ljava/nio/IntBuffer;", ref global::java.nio.IntBuffer_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.IntBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool isDirect()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.IntBuffer_.staticClass, "isDirect", "()Z", ref global::java.nio.IntBuffer_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::java.nio.IntBuffer duplicate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.IntBuffer_.staticClass, "duplicate", "()Ljava/nio/IntBuffer;", ref global::java.nio.IntBuffer_._m5) as java.nio.IntBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::java.nio.IntBuffer slice()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.IntBuffer_.staticClass, "slice", "()Ljava/nio/IntBuffer;", ref global::java.nio.IntBuffer_._m6) as java.nio.IntBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.nio.IntBuffer asReadOnlyBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.IntBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/IntBuffer;", ref global::java.nio.IntBuffer_._m7) as java.nio.IntBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override global::java.nio.IntBuffer compact()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.IntBuffer_.staticClass, "compact", "()Ljava/nio/IntBuffer;", ref global::java.nio.IntBuffer_._m8) as java.nio.IntBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override global::java.nio.ByteOrder order()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.nio.ByteOrder>(this, global::java.nio.IntBuffer_.staticClass, "order", "()Ljava/nio/ByteOrder;", ref global::java.nio.IntBuffer_._m9) as java.nio.ByteOrder;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override bool isReadOnly()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.IntBuffer_.staticClass, "isReadOnly", "()Z", ref global::java.nio.IntBuffer_._m10);
		}
		static IntBuffer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.IntBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/IntBuffer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
