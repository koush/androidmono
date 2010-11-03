namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ObjectInputStream : java.io.InputStream, ObjectInput, ObjectStreamConstants
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ObjectInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass(typeof(global::java.io.ObjectInputStream.GetField_))]
		public abstract partial class GetField : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected GetField(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public abstract global::java.lang.Object get(java.lang.String arg0, java.lang.Object arg1);
			private static global::MonoJavaBridge.MethodId _m1;
			public abstract float get(java.lang.String arg0, float arg1);
			private static global::MonoJavaBridge.MethodId _m2;
			public abstract double get(java.lang.String arg0, double arg1);
			private static global::MonoJavaBridge.MethodId _m3;
			public abstract bool get(java.lang.String arg0, bool arg1);
			private static global::MonoJavaBridge.MethodId _m4;
			public abstract byte get(java.lang.String arg0, byte arg1);
			private static global::MonoJavaBridge.MethodId _m5;
			public abstract char get(java.lang.String arg0, char arg1);
			private static global::MonoJavaBridge.MethodId _m6;
			public abstract short get(java.lang.String arg0, short arg1);
			private static global::MonoJavaBridge.MethodId _m7;
			public abstract int get(java.lang.String arg0, int arg1);
			private static global::MonoJavaBridge.MethodId _m8;
			public abstract long get(java.lang.String arg0, long arg1);
			private static global::MonoJavaBridge.MethodId _m9;
			public abstract bool defaulted(java.lang.String arg0);
			private static global::MonoJavaBridge.MethodId _m10;
			public abstract global::java.io.ObjectStreamClass getObjectStreamClass();
			private static global::MonoJavaBridge.MethodId _m11;
			public GetField() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.io.ObjectInputStream.GetField._m11.native == global::System.IntPtr.Zero)
					global::java.io.ObjectInputStream.GetField._m11 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectInputStream.GetField.staticClass, global::java.io.ObjectInputStream.GetField._m11);
				Init(@__env, handle);
			}
			static GetField()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.io.ObjectInputStream.GetField.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectInputStream$GetField"));
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.ObjectInputStream.GetField))]
		internal sealed partial class GetField_ : java.io.ObjectInputStream.GetField
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal GetField_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public override global::java.lang.Object get(java.lang.String arg0, java.lang.Object arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.io.ObjectInputStream.GetField_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public override float get(java.lang.String arg0, float arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;F)F", ref global::java.io.ObjectInputStream.GetField_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public override double get(java.lang.String arg0, double arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;D)D", ref global::java.io.ObjectInputStream.GetField_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public override bool get(java.lang.String arg0, bool arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;Z)Z", ref global::java.io.ObjectInputStream.GetField_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public override byte get(java.lang.String arg0, byte arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;B)B", ref global::java.io.ObjectInputStream.GetField_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public override char get(java.lang.String arg0, char arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;C)C", ref global::java.io.ObjectInputStream.GetField_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public override short get(java.lang.String arg0, short arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;S)S", ref global::java.io.ObjectInputStream.GetField_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m7;
			public override int get(java.lang.String arg0, int arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;I)I", ref global::java.io.ObjectInputStream.GetField_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m8;
			public override long get(java.lang.String arg0, long arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;J)J", ref global::java.io.ObjectInputStream.GetField_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m9;
			public override bool defaulted(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.ObjectInputStream.GetField_.staticClass, "defaulted", "(Ljava/lang/String;)Z", ref global::java.io.ObjectInputStream.GetField_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m10;
			public override global::java.io.ObjectStreamClass getObjectStreamClass()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.ObjectInputStream.GetField_.staticClass, "getObjectStreamClass", "()Ljava/io/ObjectStreamClass;", ref global::java.io.ObjectInputStream.GetField_._m10) as java.io.ObjectStreamClass;
			}
			static GetField_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.io.ObjectInputStream.GetField_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectInputStream$GetField"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected virtual global::java.lang.Class resolveClass(java.io.ObjectStreamClass arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.io.ObjectInputStream.staticClass, "resolveClass", "(Ljava/io/ObjectStreamClass;)Ljava/lang/Class;", ref global::java.io.ObjectInputStream._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Class;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String readLine()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.ObjectInputStream.staticClass, "readLine", "()Ljava/lang/String;", ref global::java.io.ObjectInputStream._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectInputStream.staticClass, "close", "()V", ref global::java.io.ObjectInputStream._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.Object readObject()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.ObjectInputStream.staticClass, "readObject", "()Ljava/lang/Object;", ref global::java.io.ObjectInputStream._m3) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void defaultReadObject()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectInputStream.staticClass, "defaultReadObject", "()V", ref global::java.io.ObjectInputStream._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int readInt()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInputStream.staticClass, "readInt", "()I", ref global::java.io.ObjectInputStream._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.io.ObjectInputStream.GetField readFields()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.ObjectInputStream.staticClass, "readFields", "()Ljava/io/ObjectInputStream$GetField;", ref global::java.io.ObjectInputStream._m6) as java.io.ObjectInputStream.GetField;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual char readChar()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.io.ObjectInputStream.staticClass, "readChar", "()C", ref global::java.io.ObjectInputStream._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInputStream.staticClass, "read", "()I", ref global::java.io.ObjectInputStream._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInputStream.staticClass, "read", "([BII)I", ref global::java.io.ObjectInputStream._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override int available()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInputStream.staticClass, "available", "()I", ref global::java.io.ObjectInputStream._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.lang.String readUTF()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.ObjectInputStream.staticClass, "readUTF", "()Ljava/lang/String;", ref global::java.io.ObjectInputStream._m11) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void readFully(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectInputStream.staticClass, "readFully", "([BII)V", ref global::java.io.ObjectInputStream._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void readFully(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectInputStream.staticClass, "readFully", "([B)V", ref global::java.io.ObjectInputStream._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual long readLong()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.ObjectInputStream.staticClass, "readLong", "()J", ref global::java.io.ObjectInputStream._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual byte readByte()
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.io.ObjectInputStream.staticClass, "readByte", "()B", ref global::java.io.ObjectInputStream._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual short readShort()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.io.ObjectInputStream.staticClass, "readShort", "()S", ref global::java.io.ObjectInputStream._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual float readFloat()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.io.ObjectInputStream.staticClass, "readFloat", "()F", ref global::java.io.ObjectInputStream._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual int skipBytes(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInputStream.staticClass, "skipBytes", "(I)I", ref global::java.io.ObjectInputStream._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual bool readBoolean()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.ObjectInputStream.staticClass, "readBoolean", "()Z", ref global::java.io.ObjectInputStream._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual int readUnsignedByte()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInputStream.staticClass, "readUnsignedByte", "()I", ref global::java.io.ObjectInputStream._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual int readUnsignedShort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInputStream.staticClass, "readUnsignedShort", "()I", ref global::java.io.ObjectInputStream._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual double readDouble()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.io.ObjectInputStream.staticClass, "readDouble", "()D", ref global::java.io.ObjectInputStream._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		protected virtual global::java.lang.Object readObjectOverride()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.ObjectInputStream.staticClass, "readObjectOverride", "()Ljava/lang/Object;", ref global::java.io.ObjectInputStream._m23) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual global::java.lang.Object readUnshared()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.ObjectInputStream.staticClass, "readUnshared", "()Ljava/lang/Object;", ref global::java.io.ObjectInputStream._m24) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void registerValidation(java.io.ObjectInputValidation arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectInputStream.staticClass, "registerValidation", "(Ljava/io/ObjectInputValidation;I)V", ref global::java.io.ObjectInputStream._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		protected virtual global::java.lang.Class resolveProxyClass(java.lang.String[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.io.ObjectInputStream.staticClass, "resolveProxyClass", "([Ljava/lang/String;)Ljava/lang/Class;", ref global::java.io.ObjectInputStream._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Class;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		protected virtual global::java.lang.Object resolveObject(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.ObjectInputStream.staticClass, "resolveObject", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.io.ObjectInputStream._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		protected virtual bool enableResolveObject(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.ObjectInputStream.staticClass, "enableResolveObject", "(Z)Z", ref global::java.io.ObjectInputStream._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		protected virtual void readStreamHeader()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectInputStream.staticClass, "readStreamHeader", "()V", ref global::java.io.ObjectInputStream._m29);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		protected virtual global::java.io.ObjectStreamClass readClassDescriptor()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.ObjectInputStream.staticClass, "readClassDescriptor", "()Ljava/io/ObjectStreamClass;", ref global::java.io.ObjectInputStream._m30) as java.io.ObjectStreamClass;
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public ObjectInputStream(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectInputStream._m31.native == global::System.IntPtr.Zero)
				global::java.io.ObjectInputStream._m31 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		protected ObjectInputStream() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectInputStream._m32.native == global::System.IntPtr.Zero)
				global::java.io.ObjectInputStream._m32 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._m32);
			Init(@__env, handle);
		}
		static ObjectInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ObjectInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectInputStream"));
		}
	}
}
