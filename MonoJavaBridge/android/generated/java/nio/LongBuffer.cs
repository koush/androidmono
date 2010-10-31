namespace java.nio
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.LongBuffer_))]
	public abstract partial class LongBuffer : java.nio.Buffer, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LongBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract long get();
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.nio.LongBuffer get(long[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.LongBuffer.staticClass, "get", "([J)Ljava/nio/LongBuffer;", ref global::java.nio.LongBuffer._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.LongBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.nio.LongBuffer get(long[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.LongBuffer.staticClass, "get", "([JII)Ljava/nio/LongBuffer;", ref global::java.nio.LongBuffer._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.nio.LongBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract long get(int arg0);
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.nio.LongBuffer put(java.nio.LongBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.LongBuffer.staticClass, "put", "(Ljava/nio/LongBuffer;)Ljava/nio/LongBuffer;", ref global::java.nio.LongBuffer._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.LongBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract global::java.nio.LongBuffer put(long arg0);
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract global::java.nio.LongBuffer put(int arg0, long arg1);
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.nio.LongBuffer put(long[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.LongBuffer.staticClass, "put", "([JII)Ljava/nio/LongBuffer;", ref global::java.nio.LongBuffer._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.nio.LongBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.nio.LongBuffer put(long[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.LongBuffer.staticClass, "put", "([J)Ljava/nio/LongBuffer;", ref global::java.nio.LongBuffer._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.LongBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.LongBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.nio.LongBuffer._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.LongBuffer.staticClass, "toString", "()Ljava/lang/String;", ref global::java.nio.LongBuffer._m10) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.LongBuffer.staticClass, "hashCode", "()I", ref global::java.nio.LongBuffer._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.LongBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.nio.LongBuffer._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual int compareTo(java.nio.LongBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.LongBuffer.staticClass, "compareTo", "(Ljava/nio/LongBuffer;)I", ref global::java.nio.LongBuffer._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public abstract bool isDirect();
		private static global::MonoJavaBridge.MethodId _m15;
		public sealed override bool hasArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.LongBuffer.staticClass, "hasArray", "()Z", ref global::java.nio.LongBuffer._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override global::java.lang.Object array()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.LongBuffer.staticClass, "array", "()Ljava/lang/Object;", ref global::java.nio.LongBuffer._m16) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public sealed override int arrayOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.LongBuffer.staticClass, "arrayOffset", "()I", ref global::java.nio.LongBuffer._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static global::java.nio.LongBuffer wrap(long[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.LongBuffer._m18.native == global::System.IntPtr.Zero)
				global::java.nio.LongBuffer._m18 = @__env.GetStaticMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "wrap", "([JII)Ljava/nio/LongBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.LongBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static global::java.nio.LongBuffer wrap(long[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.LongBuffer._m19.native == global::System.IntPtr.Zero)
				global::java.nio.LongBuffer._m19 = @__env.GetStaticMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "wrap", "([J)Ljava/nio/LongBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static global::java.nio.LongBuffer allocate(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.LongBuffer._m20.native == global::System.IntPtr.Zero)
				global::java.nio.LongBuffer._m20 = @__env.GetStaticMethodIDNoThrow(global::java.nio.LongBuffer.staticClass, "allocate", "(I)Ljava/nio/LongBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.LongBuffer.staticClass, global::java.nio.LongBuffer._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.LongBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public abstract global::java.nio.LongBuffer duplicate();
		private static global::MonoJavaBridge.MethodId _m22;
		public abstract global::java.nio.LongBuffer slice();
		private static global::MonoJavaBridge.MethodId _m23;
		public abstract global::java.nio.LongBuffer asReadOnlyBuffer();
		private static global::MonoJavaBridge.MethodId _m24;
		public abstract global::java.nio.LongBuffer compact();
		private static global::MonoJavaBridge.MethodId _m25;
		public abstract global::java.nio.ByteOrder order();
		static LongBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.LongBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/LongBuffer"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.LongBuffer))]
	internal sealed partial class LongBuffer_ : java.nio.LongBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal LongBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override long get()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.LongBuffer_.staticClass, "get", "()J", ref global::java.nio.LongBuffer_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override long get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.LongBuffer_.staticClass, "get", "(I)J", ref global::java.nio.LongBuffer_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.nio.LongBuffer put(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.LongBuffer_.staticClass, "put", "(J)Ljava/nio/LongBuffer;", ref global::java.nio.LongBuffer_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.LongBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.nio.LongBuffer put(int arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.LongBuffer_.staticClass, "put", "(IJ)Ljava/nio/LongBuffer;", ref global::java.nio.LongBuffer_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.LongBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool isDirect()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.LongBuffer_.staticClass, "isDirect", "()Z", ref global::java.nio.LongBuffer_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::java.nio.LongBuffer duplicate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.LongBuffer_.staticClass, "duplicate", "()Ljava/nio/LongBuffer;", ref global::java.nio.LongBuffer_._m5) as java.nio.LongBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::java.nio.LongBuffer slice()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.LongBuffer_.staticClass, "slice", "()Ljava/nio/LongBuffer;", ref global::java.nio.LongBuffer_._m6) as java.nio.LongBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.nio.LongBuffer asReadOnlyBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.LongBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/LongBuffer;", ref global::java.nio.LongBuffer_._m7) as java.nio.LongBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override global::java.nio.LongBuffer compact()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.LongBuffer_.staticClass, "compact", "()Ljava/nio/LongBuffer;", ref global::java.nio.LongBuffer_._m8) as java.nio.LongBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override global::java.nio.ByteOrder order()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.nio.ByteOrder>(this, global::java.nio.LongBuffer_.staticClass, "order", "()Ljava/nio/ByteOrder;", ref global::java.nio.LongBuffer_._m9) as java.nio.ByteOrder;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override bool isReadOnly()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.LongBuffer_.staticClass, "isReadOnly", "()Z", ref global::java.nio.LongBuffer_._m10);
		}
		static LongBuffer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.LongBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/LongBuffer"));
		}
	}
}
