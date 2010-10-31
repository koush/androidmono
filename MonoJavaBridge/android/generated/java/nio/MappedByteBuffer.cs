namespace java.nio
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.MappedByteBuffer_))]
	public abstract partial class MappedByteBuffer : java.nio.ByteBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MappedByteBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.nio.MappedByteBuffer load()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.MappedByteBuffer.staticClass, "load", "()Ljava/nio/MappedByteBuffer;", ref global::java.nio.MappedByteBuffer._m0) as java.nio.MappedByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool isLoaded()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.MappedByteBuffer.staticClass, "isLoaded", "()Z", ref global::java.nio.MappedByteBuffer._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.nio.MappedByteBuffer force()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.MappedByteBuffer.staticClass, "force", "()Ljava/nio/MappedByteBuffer;", ref global::java.nio.MappedByteBuffer._m2) as java.nio.MappedByteBuffer;
		}
		static MappedByteBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.MappedByteBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/MappedByteBuffer"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.MappedByteBuffer))]
	internal sealed partial class MappedByteBuffer_ : java.nio.MappedByteBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal MappedByteBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override byte get()
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "get", "()B", ref global::java.nio.MappedByteBuffer_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override byte get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "get", "(I)B", ref global::java.nio.MappedByteBuffer_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.nio.ByteBuffer put(byte arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "put", "(B)Ljava/nio/ByteBuffer;", ref global::java.nio.MappedByteBuffer_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.nio.ByteBuffer put(int arg0, byte arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "put", "(IB)Ljava/nio/ByteBuffer;", ref global::java.nio.MappedByteBuffer_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override short getShort(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "getShort", "(I)S", ref global::java.nio.MappedByteBuffer_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override short getShort()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "getShort", "()S", ref global::java.nio.MappedByteBuffer_._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::java.nio.ByteBuffer putShort(int arg0, short arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "putShort", "(IS)Ljava/nio/ByteBuffer;", ref global::java.nio.MappedByteBuffer_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.nio.ByteBuffer putShort(short arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "putShort", "(S)Ljava/nio/ByteBuffer;", ref global::java.nio.MappedByteBuffer_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override char getChar()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "getChar", "()C", ref global::java.nio.MappedByteBuffer_._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override char getChar(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "getChar", "(I)C", ref global::java.nio.MappedByteBuffer_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override global::java.nio.ByteBuffer putChar(int arg0, char arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "putChar", "(IC)Ljava/nio/ByteBuffer;", ref global::java.nio.MappedByteBuffer_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override global::java.nio.ByteBuffer putChar(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "putChar", "(C)Ljava/nio/ByteBuffer;", ref global::java.nio.MappedByteBuffer_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override int getInt()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "getInt", "()I", ref global::java.nio.MappedByteBuffer_._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override int getInt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "getInt", "(I)I", ref global::java.nio.MappedByteBuffer_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override global::java.nio.ByteBuffer putInt(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "putInt", "(II)Ljava/nio/ByteBuffer;", ref global::java.nio.MappedByteBuffer_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override global::java.nio.ByteBuffer putInt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "putInt", "(I)Ljava/nio/ByteBuffer;", ref global::java.nio.MappedByteBuffer_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override long getLong(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "getLong", "(I)J", ref global::java.nio.MappedByteBuffer_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public override long getLong()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "getLong", "()J", ref global::java.nio.MappedByteBuffer_._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public override global::java.nio.ByteBuffer putLong(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "putLong", "(J)Ljava/nio/ByteBuffer;", ref global::java.nio.MappedByteBuffer_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public override global::java.nio.ByteBuffer putLong(int arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "putLong", "(IJ)Ljava/nio/ByteBuffer;", ref global::java.nio.MappedByteBuffer_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public override float getFloat()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "getFloat", "()F", ref global::java.nio.MappedByteBuffer_._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public override float getFloat(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "getFloat", "(I)F", ref global::java.nio.MappedByteBuffer_._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public override global::java.nio.ByteBuffer putFloat(float arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "putFloat", "(F)Ljava/nio/ByteBuffer;", ref global::java.nio.MappedByteBuffer_._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public override global::java.nio.ByteBuffer putFloat(int arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "putFloat", "(IF)Ljava/nio/ByteBuffer;", ref global::java.nio.MappedByteBuffer_._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public override double getDouble()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "getDouble", "()D", ref global::java.nio.MappedByteBuffer_._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public override double getDouble(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "getDouble", "(I)D", ref global::java.nio.MappedByteBuffer_._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public override global::java.nio.ByteBuffer putDouble(int arg0, double arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "putDouble", "(ID)Ljava/nio/ByteBuffer;", ref global::java.nio.MappedByteBuffer_._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public override global::java.nio.ByteBuffer putDouble(double arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "putDouble", "(D)Ljava/nio/ByteBuffer;", ref global::java.nio.MappedByteBuffer_._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public override bool isDirect()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "isDirect", "()Z", ref global::java.nio.MappedByteBuffer_._m28);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public override global::java.nio.ByteBuffer duplicate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "duplicate", "()Ljava/nio/ByteBuffer;", ref global::java.nio.MappedByteBuffer_._m29) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public override global::java.nio.ByteBuffer slice()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "slice", "()Ljava/nio/ByteBuffer;", ref global::java.nio.MappedByteBuffer_._m30) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public override global::java.nio.ByteBuffer asReadOnlyBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/ByteBuffer;", ref global::java.nio.MappedByteBuffer_._m31) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public override global::java.nio.ByteBuffer compact()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "compact", "()Ljava/nio/ByteBuffer;", ref global::java.nio.MappedByteBuffer_._m32) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public override global::java.nio.CharBuffer asCharBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "asCharBuffer", "()Ljava/nio/CharBuffer;", ref global::java.nio.MappedByteBuffer_._m33) as java.nio.CharBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public override global::java.nio.ShortBuffer asShortBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "asShortBuffer", "()Ljava/nio/ShortBuffer;", ref global::java.nio.MappedByteBuffer_._m34) as java.nio.ShortBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public override global::java.nio.IntBuffer asIntBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "asIntBuffer", "()Ljava/nio/IntBuffer;", ref global::java.nio.MappedByteBuffer_._m35) as java.nio.IntBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public override global::java.nio.LongBuffer asLongBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "asLongBuffer", "()Ljava/nio/LongBuffer;", ref global::java.nio.MappedByteBuffer_._m36) as java.nio.LongBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public override global::java.nio.FloatBuffer asFloatBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "asFloatBuffer", "()Ljava/nio/FloatBuffer;", ref global::java.nio.MappedByteBuffer_._m37) as java.nio.FloatBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public override global::java.nio.DoubleBuffer asDoubleBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "asDoubleBuffer", "()Ljava/nio/DoubleBuffer;", ref global::java.nio.MappedByteBuffer_._m38) as java.nio.DoubleBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public override bool isReadOnly()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.MappedByteBuffer_.staticClass, "isReadOnly", "()Z", ref global::java.nio.MappedByteBuffer_._m39);
		}
		static MappedByteBuffer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.MappedByteBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/MappedByteBuffer"));
		}
	}
}
