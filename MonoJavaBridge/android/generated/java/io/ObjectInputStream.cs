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
			internal static global::MonoJavaBridge.MethodId _get19167;
			public abstract global::java.lang.Object get(java.lang.String arg0, java.lang.Object arg1);
			internal static global::MonoJavaBridge.MethodId _get19168;
			public abstract float get(java.lang.String arg0, float arg1);
			internal static global::MonoJavaBridge.MethodId _get19169;
			public abstract double get(java.lang.String arg0, double arg1);
			internal static global::MonoJavaBridge.MethodId _get19170;
			public abstract bool get(java.lang.String arg0, bool arg1);
			internal static global::MonoJavaBridge.MethodId _get19171;
			public abstract byte get(java.lang.String arg0, byte arg1);
			internal static global::MonoJavaBridge.MethodId _get19172;
			public abstract char get(java.lang.String arg0, char arg1);
			internal static global::MonoJavaBridge.MethodId _get19173;
			public abstract short get(java.lang.String arg0, short arg1);
			internal static global::MonoJavaBridge.MethodId _get19174;
			public abstract int get(java.lang.String arg0, int arg1);
			internal static global::MonoJavaBridge.MethodId _get19175;
			public abstract long get(java.lang.String arg0, long arg1);
			internal static global::MonoJavaBridge.MethodId _defaulted19176;
			public abstract bool defaulted(java.lang.String arg0);
			internal static global::MonoJavaBridge.MethodId _getObjectStreamClass19177;
			public abstract global::java.io.ObjectStreamClass getObjectStreamClass();
			internal static global::MonoJavaBridge.MethodId _GetField19178;
			public GetField() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.io.ObjectInputStream.GetField._GetField19178.native == global::System.IntPtr.Zero)
					global::java.io.ObjectInputStream.GetField._GetField19178 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectInputStream.GetField.staticClass, global::java.io.ObjectInputStream.GetField._GetField19178);
				Init(@__env, handle);
			}
			static GetField()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.io.ObjectInputStream.GetField.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectInputStream$GetField"));
			}
			internal static void InitJNI()
			{
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.ObjectInputStream.GetField))]
		internal sealed partial class GetField_ : java.io.ObjectInputStream.GetField
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal GetField_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _get19179;
			public override global::java.lang.Object get(java.lang.String arg0, java.lang.Object arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.io.ObjectInputStream.GetField_._get19179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
			}
			internal static global::MonoJavaBridge.MethodId _get19180;
			public override float get(java.lang.String arg0, float arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;F)F", ref global::java.io.ObjectInputStream.GetField_._get19180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _get19181;
			public override double get(java.lang.String arg0, double arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;D)D", ref global::java.io.ObjectInputStream.GetField_._get19181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _get19182;
			public override bool get(java.lang.String arg0, bool arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;Z)Z", ref global::java.io.ObjectInputStream.GetField_._get19182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _get19183;
			public override byte get(java.lang.String arg0, byte arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;B)B", ref global::java.io.ObjectInputStream.GetField_._get19183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _get19184;
			public override char get(java.lang.String arg0, char arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;C)C", ref global::java.io.ObjectInputStream.GetField_._get19184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _get19185;
			public override short get(java.lang.String arg0, short arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;S)S", ref global::java.io.ObjectInputStream.GetField_._get19185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _get19186;
			public override int get(java.lang.String arg0, int arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;I)I", ref global::java.io.ObjectInputStream.GetField_._get19186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _get19187;
			public override long get(java.lang.String arg0, long arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;J)J", ref global::java.io.ObjectInputStream.GetField_._get19187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _defaulted19188;
			public override bool defaulted(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.ObjectInputStream.GetField_.staticClass, "defaulted", "(Ljava/lang/String;)Z", ref global::java.io.ObjectInputStream.GetField_._defaulted19188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _getObjectStreamClass19189;
			public override global::java.io.ObjectStreamClass getObjectStreamClass()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.ObjectInputStream.GetField_.staticClass, "getObjectStreamClass", "()Ljava/io/ObjectStreamClass;", ref global::java.io.ObjectInputStream.GetField_._getObjectStreamClass19189) as java.io.ObjectStreamClass;
			}
			static GetField_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.io.ObjectInputStream.GetField_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectInputStream$GetField"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _resolveClass19190;
		protected virtual global::java.lang.Class resolveClass(java.io.ObjectStreamClass arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.io.ObjectInputStream.staticClass, "resolveClass", "(Ljava/io/ObjectStreamClass;)Ljava/lang/Class;", ref global::java.io.ObjectInputStream._resolveClass19190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _readLine19191;
		public virtual global::java.lang.String readLine()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.ObjectInputStream.staticClass, "readLine", "()Ljava/lang/String;", ref global::java.io.ObjectInputStream._readLine19191) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close19192;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectInputStream.staticClass, "close", "()V", ref global::java.io.ObjectInputStream._close19192);
		}
		internal static global::MonoJavaBridge.MethodId _readObject19193;
		public virtual global::java.lang.Object readObject()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.ObjectInputStream.staticClass, "readObject", "()Ljava/lang/Object;", ref global::java.io.ObjectInputStream._readObject19193) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _defaultReadObject19194;
		public virtual void defaultReadObject()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectInputStream.staticClass, "defaultReadObject", "()V", ref global::java.io.ObjectInputStream._defaultReadObject19194);
		}
		internal static global::MonoJavaBridge.MethodId _readInt19195;
		public virtual int readInt()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInputStream.staticClass, "readInt", "()I", ref global::java.io.ObjectInputStream._readInt19195);
		}
		internal static global::MonoJavaBridge.MethodId _readFields19196;
		public virtual global::java.io.ObjectInputStream.GetField readFields()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.ObjectInputStream.staticClass, "readFields", "()Ljava/io/ObjectInputStream$GetField;", ref global::java.io.ObjectInputStream._readFields19196) as java.io.ObjectInputStream.GetField;
		}
		internal static global::MonoJavaBridge.MethodId _readChar19197;
		public virtual char readChar()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.io.ObjectInputStream.staticClass, "readChar", "()C", ref global::java.io.ObjectInputStream._readChar19197);
		}
		internal static global::MonoJavaBridge.MethodId _read19198;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInputStream.staticClass, "read", "()I", ref global::java.io.ObjectInputStream._read19198);
		}
		internal static global::MonoJavaBridge.MethodId _read19199;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInputStream.staticClass, "read", "([BII)I", ref global::java.io.ObjectInputStream._read19199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _available19200;
		public override int available()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInputStream.staticClass, "available", "()I", ref global::java.io.ObjectInputStream._available19200);
		}
		internal static global::MonoJavaBridge.MethodId _readUTF19201;
		public virtual global::java.lang.String readUTF()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.ObjectInputStream.staticClass, "readUTF", "()Ljava/lang/String;", ref global::java.io.ObjectInputStream._readUTF19201) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readFully19202;
		public virtual void readFully(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectInputStream.staticClass, "readFully", "([BII)V", ref global::java.io.ObjectInputStream._readFully19202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _readFully19203;
		public virtual void readFully(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectInputStream.staticClass, "readFully", "([B)V", ref global::java.io.ObjectInputStream._readFully19203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readLong19204;
		public virtual long readLong()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.io.ObjectInputStream.staticClass, "readLong", "()J", ref global::java.io.ObjectInputStream._readLong19204);
		}
		internal static global::MonoJavaBridge.MethodId _readByte19205;
		public virtual byte readByte()
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.io.ObjectInputStream.staticClass, "readByte", "()B", ref global::java.io.ObjectInputStream._readByte19205);
		}
		internal static global::MonoJavaBridge.MethodId _readShort19206;
		public virtual short readShort()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.io.ObjectInputStream.staticClass, "readShort", "()S", ref global::java.io.ObjectInputStream._readShort19206);
		}
		internal static global::MonoJavaBridge.MethodId _readFloat19207;
		public virtual float readFloat()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.io.ObjectInputStream.staticClass, "readFloat", "()F", ref global::java.io.ObjectInputStream._readFloat19207);
		}
		internal static global::MonoJavaBridge.MethodId _skipBytes19208;
		public virtual int skipBytes(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInputStream.staticClass, "skipBytes", "(I)I", ref global::java.io.ObjectInputStream._skipBytes19208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readBoolean19209;
		public virtual bool readBoolean()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.ObjectInputStream.staticClass, "readBoolean", "()Z", ref global::java.io.ObjectInputStream._readBoolean19209);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedByte19210;
		public virtual int readUnsignedByte()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInputStream.staticClass, "readUnsignedByte", "()I", ref global::java.io.ObjectInputStream._readUnsignedByte19210);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedShort19211;
		public virtual int readUnsignedShort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.ObjectInputStream.staticClass, "readUnsignedShort", "()I", ref global::java.io.ObjectInputStream._readUnsignedShort19211);
		}
		internal static global::MonoJavaBridge.MethodId _readDouble19212;
		public virtual double readDouble()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.io.ObjectInputStream.staticClass, "readDouble", "()D", ref global::java.io.ObjectInputStream._readDouble19212);
		}
		internal static global::MonoJavaBridge.MethodId _readObjectOverride19213;
		protected virtual global::java.lang.Object readObjectOverride()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.ObjectInputStream.staticClass, "readObjectOverride", "()Ljava/lang/Object;", ref global::java.io.ObjectInputStream._readObjectOverride19213) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _readUnshared19214;
		public virtual global::java.lang.Object readUnshared()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.ObjectInputStream.staticClass, "readUnshared", "()Ljava/lang/Object;", ref global::java.io.ObjectInputStream._readUnshared19214) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _registerValidation19215;
		public virtual void registerValidation(java.io.ObjectInputValidation arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectInputStream.staticClass, "registerValidation", "(Ljava/io/ObjectInputValidation;I)V", ref global::java.io.ObjectInputStream._registerValidation19215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _resolveProxyClass19216;
		protected virtual global::java.lang.Class resolveProxyClass(java.lang.String[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.io.ObjectInputStream.staticClass, "resolveProxyClass", "([Ljava/lang/String;)Ljava/lang/Class;", ref global::java.io.ObjectInputStream._resolveProxyClass19216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _resolveObject19217;
		protected virtual global::java.lang.Object resolveObject(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.ObjectInputStream.staticClass, "resolveObject", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.io.ObjectInputStream._resolveObject19217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _enableResolveObject19218;
		protected virtual bool enableResolveObject(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.ObjectInputStream.staticClass, "enableResolveObject", "(Z)Z", ref global::java.io.ObjectInputStream._enableResolveObject19218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readStreamHeader19219;
		protected virtual void readStreamHeader()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.ObjectInputStream.staticClass, "readStreamHeader", "()V", ref global::java.io.ObjectInputStream._readStreamHeader19219);
		}
		internal static global::MonoJavaBridge.MethodId _readClassDescriptor19220;
		protected virtual global::java.io.ObjectStreamClass readClassDescriptor()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.ObjectInputStream.staticClass, "readClassDescriptor", "()Ljava/io/ObjectStreamClass;", ref global::java.io.ObjectInputStream._readClassDescriptor19220) as java.io.ObjectStreamClass;
		}
		internal static global::MonoJavaBridge.MethodId _ObjectInputStream19221;
		public ObjectInputStream(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectInputStream._ObjectInputStream19221.native == global::System.IntPtr.Zero)
				global::java.io.ObjectInputStream._ObjectInputStream19221 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._ObjectInputStream19221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ObjectInputStream19222;
		protected ObjectInputStream() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.ObjectInputStream._ObjectInputStream19222.native == global::System.IntPtr.Zero)
				global::java.io.ObjectInputStream._ObjectInputStream19222 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._ObjectInputStream19222);
			Init(@__env, handle);
		}
		static ObjectInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ObjectInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectInputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}
