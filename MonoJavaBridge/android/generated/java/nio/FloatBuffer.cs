namespace java.nio
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.FloatBuffer_))]
	public abstract partial class FloatBuffer : java.nio.Buffer, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FloatBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract float get();
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.nio.FloatBuffer get(float[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.FloatBuffer.staticClass, "get", "([F)Ljava/nio/FloatBuffer;", ref global::java.nio.FloatBuffer._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.FloatBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.nio.FloatBuffer get(float[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.FloatBuffer.staticClass, "get", "([FII)Ljava/nio/FloatBuffer;", ref global::java.nio.FloatBuffer._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.nio.FloatBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract float get(int arg0);
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.nio.FloatBuffer put(java.nio.FloatBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.FloatBuffer.staticClass, "put", "(Ljava/nio/FloatBuffer;)Ljava/nio/FloatBuffer;", ref global::java.nio.FloatBuffer._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.FloatBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract global::java.nio.FloatBuffer put(float arg0);
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract global::java.nio.FloatBuffer put(int arg0, float arg1);
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.nio.FloatBuffer put(float[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.FloatBuffer.staticClass, "put", "([FII)Ljava/nio/FloatBuffer;", ref global::java.nio.FloatBuffer._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.nio.FloatBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.nio.FloatBuffer put(float[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.FloatBuffer.staticClass, "put", "([F)Ljava/nio/FloatBuffer;", ref global::java.nio.FloatBuffer._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.FloatBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.FloatBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.nio.FloatBuffer._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.FloatBuffer.staticClass, "toString", "()Ljava/lang/String;", ref global::java.nio.FloatBuffer._m10) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.FloatBuffer.staticClass, "hashCode", "()I", ref global::java.nio.FloatBuffer._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.FloatBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.nio.FloatBuffer._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual int compareTo(java.nio.FloatBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.FloatBuffer.staticClass, "compareTo", "(Ljava/nio/FloatBuffer;)I", ref global::java.nio.FloatBuffer._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public abstract bool isDirect();
		private static global::MonoJavaBridge.MethodId _m15;
		public sealed override bool hasArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.FloatBuffer.staticClass, "hasArray", "()Z", ref global::java.nio.FloatBuffer._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override global::java.lang.Object array()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.FloatBuffer.staticClass, "array", "()Ljava/lang/Object;", ref global::java.nio.FloatBuffer._m16) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public sealed override int arrayOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.FloatBuffer.staticClass, "arrayOffset", "()I", ref global::java.nio.FloatBuffer._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static global::java.nio.FloatBuffer wrap(float[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.FloatBuffer._m18.native == global::System.IntPtr.Zero)
				global::java.nio.FloatBuffer._m18 = @__env.GetStaticMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "wrap", "([FII)Ljava/nio/FloatBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.FloatBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static global::java.nio.FloatBuffer wrap(float[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.FloatBuffer._m19.native == global::System.IntPtr.Zero)
				global::java.nio.FloatBuffer._m19 = @__env.GetStaticMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "wrap", "([F)Ljava/nio/FloatBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static global::java.nio.FloatBuffer allocate(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.FloatBuffer._m20.native == global::System.IntPtr.Zero)
				global::java.nio.FloatBuffer._m20 = @__env.GetStaticMethodIDNoThrow(global::java.nio.FloatBuffer.staticClass, "allocate", "(I)Ljava/nio/FloatBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.FloatBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public abstract global::java.nio.FloatBuffer duplicate();
		private static global::MonoJavaBridge.MethodId _m22;
		public abstract global::java.nio.FloatBuffer slice();
		private static global::MonoJavaBridge.MethodId _m23;
		public abstract global::java.nio.FloatBuffer asReadOnlyBuffer();
		private static global::MonoJavaBridge.MethodId _m24;
		public abstract global::java.nio.FloatBuffer compact();
		private static global::MonoJavaBridge.MethodId _m25;
		public abstract global::java.nio.ByteOrder order();
		static FloatBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.FloatBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/FloatBuffer"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.FloatBuffer))]
	internal sealed partial class FloatBuffer_ : java.nio.FloatBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal FloatBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override float get()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.nio.FloatBuffer_.staticClass, "get", "()F", ref global::java.nio.FloatBuffer_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override float get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.nio.FloatBuffer_.staticClass, "get", "(I)F", ref global::java.nio.FloatBuffer_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.nio.FloatBuffer put(float arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.FloatBuffer_.staticClass, "put", "(F)Ljava/nio/FloatBuffer;", ref global::java.nio.FloatBuffer_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.FloatBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.nio.FloatBuffer put(int arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.FloatBuffer_.staticClass, "put", "(IF)Ljava/nio/FloatBuffer;", ref global::java.nio.FloatBuffer_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.FloatBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool isDirect()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.FloatBuffer_.staticClass, "isDirect", "()Z", ref global::java.nio.FloatBuffer_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::java.nio.FloatBuffer duplicate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.FloatBuffer_.staticClass, "duplicate", "()Ljava/nio/FloatBuffer;", ref global::java.nio.FloatBuffer_._m5) as java.nio.FloatBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::java.nio.FloatBuffer slice()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.FloatBuffer_.staticClass, "slice", "()Ljava/nio/FloatBuffer;", ref global::java.nio.FloatBuffer_._m6) as java.nio.FloatBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.nio.FloatBuffer asReadOnlyBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.FloatBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/FloatBuffer;", ref global::java.nio.FloatBuffer_._m7) as java.nio.FloatBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override global::java.nio.FloatBuffer compact()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.FloatBuffer_.staticClass, "compact", "()Ljava/nio/FloatBuffer;", ref global::java.nio.FloatBuffer_._m8) as java.nio.FloatBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override global::java.nio.ByteOrder order()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.nio.ByteOrder>(this, global::java.nio.FloatBuffer_.staticClass, "order", "()Ljava/nio/ByteOrder;", ref global::java.nio.FloatBuffer_._m9) as java.nio.ByteOrder;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override bool isReadOnly()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.FloatBuffer_.staticClass, "isReadOnly", "()Z", ref global::java.nio.FloatBuffer_._m10);
		}
		static FloatBuffer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.FloatBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/FloatBuffer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
