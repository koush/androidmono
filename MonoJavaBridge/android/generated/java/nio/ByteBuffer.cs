namespace java.nio
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.ByteBuffer_))]
	public abstract partial class ByteBuffer : java.nio.Buffer, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ByteBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract byte get();
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.nio.ByteBuffer get(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer.staticClass, "get", "([B)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.nio.ByteBuffer get(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer.staticClass, "get", "([BII)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract byte get(int arg0);
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.nio.ByteBuffer put(java.nio.ByteBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer.staticClass, "put", "(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.nio.ByteBuffer put(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer.staticClass, "put", "([B)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract global::java.nio.ByteBuffer put(byte arg0);
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract global::java.nio.ByteBuffer put(int arg0, byte arg1);
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.nio.ByteBuffer put(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer.staticClass, "put", "([BII)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.ByteBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.nio.ByteBuffer._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.ByteBuffer.staticClass, "toString", "()Ljava/lang/String;", ref global::java.nio.ByteBuffer._m10) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.ByteBuffer.staticClass, "hashCode", "()I", ref global::java.nio.ByteBuffer._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.ByteBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.nio.ByteBuffer._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual int compareTo(java.nio.ByteBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.ByteBuffer.staticClass, "compareTo", "(Ljava/nio/ByteBuffer;)I", ref global::java.nio.ByteBuffer._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public abstract short getShort(int arg0);
		private static global::MonoJavaBridge.MethodId _m15;
		public abstract short getShort();
		private static global::MonoJavaBridge.MethodId _m16;
		public abstract global::java.nio.ByteBuffer putShort(int arg0, short arg1);
		private static global::MonoJavaBridge.MethodId _m17;
		public abstract global::java.nio.ByteBuffer putShort(short arg0);
		private static global::MonoJavaBridge.MethodId _m18;
		public abstract char getChar();
		private static global::MonoJavaBridge.MethodId _m19;
		public abstract char getChar(int arg0);
		private static global::MonoJavaBridge.MethodId _m20;
		public abstract global::java.nio.ByteBuffer putChar(int arg0, char arg1);
		private static global::MonoJavaBridge.MethodId _m21;
		public abstract global::java.nio.ByteBuffer putChar(char arg0);
		private static global::MonoJavaBridge.MethodId _m22;
		public abstract int getInt();
		private static global::MonoJavaBridge.MethodId _m23;
		public abstract int getInt(int arg0);
		private static global::MonoJavaBridge.MethodId _m24;
		public abstract global::java.nio.ByteBuffer putInt(int arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m25;
		public abstract global::java.nio.ByteBuffer putInt(int arg0);
		private static global::MonoJavaBridge.MethodId _m26;
		public abstract long getLong(int arg0);
		private static global::MonoJavaBridge.MethodId _m27;
		public abstract long getLong();
		private static global::MonoJavaBridge.MethodId _m28;
		public abstract global::java.nio.ByteBuffer putLong(long arg0);
		private static global::MonoJavaBridge.MethodId _m29;
		public abstract global::java.nio.ByteBuffer putLong(int arg0, long arg1);
		private static global::MonoJavaBridge.MethodId _m30;
		public abstract float getFloat();
		private static global::MonoJavaBridge.MethodId _m31;
		public abstract float getFloat(int arg0);
		private static global::MonoJavaBridge.MethodId _m32;
		public abstract global::java.nio.ByteBuffer putFloat(float arg0);
		private static global::MonoJavaBridge.MethodId _m33;
		public abstract global::java.nio.ByteBuffer putFloat(int arg0, float arg1);
		private static global::MonoJavaBridge.MethodId _m34;
		public abstract double getDouble();
		private static global::MonoJavaBridge.MethodId _m35;
		public abstract double getDouble(int arg0);
		private static global::MonoJavaBridge.MethodId _m36;
		public abstract global::java.nio.ByteBuffer putDouble(int arg0, double arg1);
		private static global::MonoJavaBridge.MethodId _m37;
		public abstract global::java.nio.ByteBuffer putDouble(double arg0);
		private static global::MonoJavaBridge.MethodId _m38;
		public abstract bool isDirect();
		private static global::MonoJavaBridge.MethodId _m39;
		public sealed override bool hasArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.ByteBuffer.staticClass, "hasArray", "()Z", ref global::java.nio.ByteBuffer._m39);
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public override global::java.lang.Object array()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer.staticClass, "array", "()Ljava/lang/Object;", ref global::java.nio.ByteBuffer._m40) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public sealed override int arrayOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.ByteBuffer.staticClass, "arrayOffset", "()I", ref global::java.nio.ByteBuffer._m41);
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public static global::java.nio.ByteBuffer wrap(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.ByteBuffer._m42.native == global::System.IntPtr.Zero)
				global::java.nio.ByteBuffer._m42 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "wrap", "([B)Ljava/nio/ByteBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public static global::java.nio.ByteBuffer wrap(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.ByteBuffer._m43.native == global::System.IntPtr.Zero)
				global::java.nio.ByteBuffer._m43 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "wrap", "([BII)Ljava/nio/ByteBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public static global::java.nio.ByteBuffer allocate(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.ByteBuffer._m44.native == global::System.IntPtr.Zero)
				global::java.nio.ByteBuffer._m44 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "allocate", "(I)Ljava/nio/ByteBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public abstract global::java.nio.ByteBuffer duplicate();
		private static global::MonoJavaBridge.MethodId _m46;
		public static global::java.nio.ByteBuffer allocateDirect(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.ByteBuffer._m46.native == global::System.IntPtr.Zero)
				global::java.nio.ByteBuffer._m46 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ByteBuffer.staticClass, "allocateDirect", "(I)Ljava/nio/ByteBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ByteBuffer.staticClass, global::java.nio.ByteBuffer._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public abstract global::java.nio.ByteBuffer slice();
		private static global::MonoJavaBridge.MethodId _m48;
		public abstract global::java.nio.ByteBuffer asReadOnlyBuffer();
		private static global::MonoJavaBridge.MethodId _m49;
		public abstract global::java.nio.ByteBuffer compact();
		private static global::MonoJavaBridge.MethodId _m50;
		public virtual global::java.nio.ByteBuffer order(java.nio.ByteOrder arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer.staticClass, "order", "(Ljava/nio/ByteOrder;)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public virtual global::java.nio.ByteOrder order()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.nio.ByteOrder>(this, global::java.nio.ByteBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;", ref global::java.nio.ByteBuffer._m51) as java.nio.ByteOrder;
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public abstract global::java.nio.CharBuffer asCharBuffer();
		private static global::MonoJavaBridge.MethodId _m53;
		public abstract global::java.nio.ShortBuffer asShortBuffer();
		private static global::MonoJavaBridge.MethodId _m54;
		public abstract global::java.nio.IntBuffer asIntBuffer();
		private static global::MonoJavaBridge.MethodId _m55;
		public abstract global::java.nio.LongBuffer asLongBuffer();
		private static global::MonoJavaBridge.MethodId _m56;
		public abstract global::java.nio.FloatBuffer asFloatBuffer();
		private static global::MonoJavaBridge.MethodId _m57;
		public abstract global::java.nio.DoubleBuffer asDoubleBuffer();
		static ByteBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.ByteBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/ByteBuffer"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.ByteBuffer))]
	internal sealed partial class ByteBuffer_ : java.nio.ByteBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ByteBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override byte get()
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.nio.ByteBuffer_.staticClass, "get", "()B", ref global::java.nio.ByteBuffer_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override byte get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.nio.ByteBuffer_.staticClass, "get", "(I)B", ref global::java.nio.ByteBuffer_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.nio.ByteBuffer put(byte arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "put", "(B)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.nio.ByteBuffer put(int arg0, byte arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "put", "(IB)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override short getShort(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.nio.ByteBuffer_.staticClass, "getShort", "(I)S", ref global::java.nio.ByteBuffer_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override short getShort()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.nio.ByteBuffer_.staticClass, "getShort", "()S", ref global::java.nio.ByteBuffer_._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::java.nio.ByteBuffer putShort(int arg0, short arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "putShort", "(IS)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.nio.ByteBuffer putShort(short arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "putShort", "(S)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override char getChar()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.nio.ByteBuffer_.staticClass, "getChar", "()C", ref global::java.nio.ByteBuffer_._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override char getChar(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.nio.ByteBuffer_.staticClass, "getChar", "(I)C", ref global::java.nio.ByteBuffer_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override global::java.nio.ByteBuffer putChar(int arg0, char arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "putChar", "(IC)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override global::java.nio.ByteBuffer putChar(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "putChar", "(C)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override int getInt()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.ByteBuffer_.staticClass, "getInt", "()I", ref global::java.nio.ByteBuffer_._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override int getInt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.ByteBuffer_.staticClass, "getInt", "(I)I", ref global::java.nio.ByteBuffer_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override global::java.nio.ByteBuffer putInt(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "putInt", "(II)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override global::java.nio.ByteBuffer putInt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "putInt", "(I)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override long getLong(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.ByteBuffer_.staticClass, "getLong", "(I)J", ref global::java.nio.ByteBuffer_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public override long getLong()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.ByteBuffer_.staticClass, "getLong", "()J", ref global::java.nio.ByteBuffer_._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public override global::java.nio.ByteBuffer putLong(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "putLong", "(J)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public override global::java.nio.ByteBuffer putLong(int arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "putLong", "(IJ)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public override float getFloat()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.nio.ByteBuffer_.staticClass, "getFloat", "()F", ref global::java.nio.ByteBuffer_._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public override float getFloat(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.nio.ByteBuffer_.staticClass, "getFloat", "(I)F", ref global::java.nio.ByteBuffer_._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public override global::java.nio.ByteBuffer putFloat(float arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "putFloat", "(F)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public override global::java.nio.ByteBuffer putFloat(int arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "putFloat", "(IF)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public override double getDouble()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.nio.ByteBuffer_.staticClass, "getDouble", "()D", ref global::java.nio.ByteBuffer_._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public override double getDouble(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.nio.ByteBuffer_.staticClass, "getDouble", "(I)D", ref global::java.nio.ByteBuffer_._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public override global::java.nio.ByteBuffer putDouble(int arg0, double arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "putDouble", "(ID)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public override global::java.nio.ByteBuffer putDouble(double arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "putDouble", "(D)Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public override bool isDirect()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.ByteBuffer_.staticClass, "isDirect", "()Z", ref global::java.nio.ByteBuffer_._m28);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public override global::java.nio.ByteBuffer duplicate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "duplicate", "()Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._m29) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public override global::java.nio.ByteBuffer slice()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "slice", "()Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._m30) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public override global::java.nio.ByteBuffer asReadOnlyBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._m31) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public override global::java.nio.ByteBuffer compact()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "compact", "()Ljava/nio/ByteBuffer;", ref global::java.nio.ByteBuffer_._m32) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public override global::java.nio.CharBuffer asCharBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "asCharBuffer", "()Ljava/nio/CharBuffer;", ref global::java.nio.ByteBuffer_._m33) as java.nio.CharBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public override global::java.nio.ShortBuffer asShortBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "asShortBuffer", "()Ljava/nio/ShortBuffer;", ref global::java.nio.ByteBuffer_._m34) as java.nio.ShortBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public override global::java.nio.IntBuffer asIntBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "asIntBuffer", "()Ljava/nio/IntBuffer;", ref global::java.nio.ByteBuffer_._m35) as java.nio.IntBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public override global::java.nio.LongBuffer asLongBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "asLongBuffer", "()Ljava/nio/LongBuffer;", ref global::java.nio.ByteBuffer_._m36) as java.nio.LongBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public override global::java.nio.FloatBuffer asFloatBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "asFloatBuffer", "()Ljava/nio/FloatBuffer;", ref global::java.nio.ByteBuffer_._m37) as java.nio.FloatBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public override global::java.nio.DoubleBuffer asDoubleBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.ByteBuffer_.staticClass, "asDoubleBuffer", "()Ljava/nio/DoubleBuffer;", ref global::java.nio.ByteBuffer_._m38) as java.nio.DoubleBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public override bool isReadOnly()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.ByteBuffer_.staticClass, "isReadOnly", "()Z", ref global::java.nio.ByteBuffer_._m39);
		}
		static ByteBuffer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.ByteBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/ByteBuffer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
