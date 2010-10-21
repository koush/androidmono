namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ObjectInputStream : java.io.InputStream, ObjectInput, ObjectStreamConstants
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ObjectInputStream()
		{
			InitJNI();
		}
		protected ObjectInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass(typeof(global::java.io.ObjectInputStream.GetField_))]
		public abstract partial class GetField : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static GetField()
			{
				InitJNI();
			}
			protected GetField(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _get19049;
			public abstract global::java.lang.Object get(java.lang.String arg0, java.lang.Object arg1);
			internal static global::MonoJavaBridge.MethodId _get19050;
			public abstract float get(java.lang.String arg0, float arg1);
			internal static global::MonoJavaBridge.MethodId _get19051;
			public abstract double get(java.lang.String arg0, double arg1);
			internal static global::MonoJavaBridge.MethodId _get19052;
			public abstract bool get(java.lang.String arg0, bool arg1);
			internal static global::MonoJavaBridge.MethodId _get19053;
			public abstract byte get(java.lang.String arg0, byte arg1);
			internal static global::MonoJavaBridge.MethodId _get19054;
			public abstract char get(java.lang.String arg0, char arg1);
			internal static global::MonoJavaBridge.MethodId _get19055;
			public abstract short get(java.lang.String arg0, short arg1);
			internal static global::MonoJavaBridge.MethodId _get19056;
			public abstract int get(java.lang.String arg0, int arg1);
			internal static global::MonoJavaBridge.MethodId _get19057;
			public abstract long get(java.lang.String arg0, long arg1);
			internal static global::MonoJavaBridge.MethodId _defaulted19058;
			public abstract bool defaulted(java.lang.String arg0);
			internal static global::MonoJavaBridge.MethodId _getObjectStreamClass19059;
			public abstract global::java.io.ObjectStreamClass getObjectStreamClass();
			internal static global::MonoJavaBridge.MethodId _GetField19060;
			public GetField()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectInputStream.GetField.staticClass, global::java.io.ObjectInputStream.GetField._GetField19060);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.io.ObjectInputStream.GetField.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectInputStream$GetField"));
				global::java.io.ObjectInputStream.GetField._get19049 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "get", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;");
				global::java.io.ObjectInputStream.GetField._get19050 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "get", "(Ljava/lang/String;F)F");
				global::java.io.ObjectInputStream.GetField._get19051 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "get", "(Ljava/lang/String;D)D");
				global::java.io.ObjectInputStream.GetField._get19052 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "get", "(Ljava/lang/String;Z)Z");
				global::java.io.ObjectInputStream.GetField._get19053 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "get", "(Ljava/lang/String;B)B");
				global::java.io.ObjectInputStream.GetField._get19054 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "get", "(Ljava/lang/String;C)C");
				global::java.io.ObjectInputStream.GetField._get19055 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "get", "(Ljava/lang/String;S)S");
				global::java.io.ObjectInputStream.GetField._get19056 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "get", "(Ljava/lang/String;I)I");
				global::java.io.ObjectInputStream.GetField._get19057 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "get", "(Ljava/lang/String;J)J");
				global::java.io.ObjectInputStream.GetField._defaulted19058 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "defaulted", "(Ljava/lang/String;)Z");
				global::java.io.ObjectInputStream.GetField._getObjectStreamClass19059 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "getObjectStreamClass", "()Ljava/io/ObjectStreamClass;");
				global::java.io.ObjectInputStream.GetField._GetField19060 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "<init>", "()V");
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.ObjectInputStream.GetField))]
		public sealed partial class GetField_ : java.io.ObjectInputStream.GetField
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static GetField_()
			{
				InitJNI();
			}
			internal GetField_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _get19061;
			public override global::java.lang.Object get(java.lang.String arg0, java.lang.Object arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._get19061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._get19061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			}
			internal static global::MonoJavaBridge.MethodId _get19062;
			public override float get(java.lang.String arg0, float arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallFloatMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._get19062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._get19062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _get19063;
			public override double get(java.lang.String arg0, double arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallDoubleMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._get19063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._get19063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _get19064;
			public override bool get(java.lang.String arg0, bool arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._get19064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._get19064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _get19065;
			public override byte get(java.lang.String arg0, byte arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallByteMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._get19065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._get19065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _get19066;
			public override char get(java.lang.String arg0, char arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallCharMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._get19066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._get19066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _get19067;
			public override short get(java.lang.String arg0, short arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallShortMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._get19067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._get19067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _get19068;
			public override int get(java.lang.String arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._get19068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._get19068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _get19069;
			public override long get(java.lang.String arg0, long arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._get19069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._get19069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _defaulted19070;
			public override bool defaulted(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._defaulted19070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._defaulted19070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _getObjectStreamClass19071;
			public override global::java.io.ObjectStreamClass getObjectStreamClass() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._getObjectStreamClass19071)) as java.io.ObjectStreamClass;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._getObjectStreamClass19071)) as java.io.ObjectStreamClass;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.io.ObjectInputStream.GetField_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectInputStream$GetField"));
				global::java.io.ObjectInputStream.GetField_._get19061 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;");
				global::java.io.ObjectInputStream.GetField_._get19062 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;F)F");
				global::java.io.ObjectInputStream.GetField_._get19063 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;D)D");
				global::java.io.ObjectInputStream.GetField_._get19064 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;Z)Z");
				global::java.io.ObjectInputStream.GetField_._get19065 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;B)B");
				global::java.io.ObjectInputStream.GetField_._get19066 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;C)C");
				global::java.io.ObjectInputStream.GetField_._get19067 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;S)S");
				global::java.io.ObjectInputStream.GetField_._get19068 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;I)I");
				global::java.io.ObjectInputStream.GetField_._get19069 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;J)J");
				global::java.io.ObjectInputStream.GetField_._defaulted19070 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "defaulted", "(Ljava/lang/String;)Z");
				global::java.io.ObjectInputStream.GetField_._getObjectStreamClass19071 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "getObjectStreamClass", "()Ljava/io/ObjectStreamClass;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _resolveClass19072;
		protected virtual global::java.lang.Class resolveClass(java.io.ObjectStreamClass arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream._resolveClass19072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._resolveClass19072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _readLine19073;
		public virtual global::java.lang.String readLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream._readLine19073)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readLine19073)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close19074;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream._close19074);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._close19074);
		}
		internal static global::MonoJavaBridge.MethodId _readObject19075;
		public virtual global::java.lang.Object readObject() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream._readObject19075)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readObject19075)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _defaultReadObject19076;
		public virtual void defaultReadObject() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream._defaultReadObject19076);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._defaultReadObject19076);
		}
		internal static global::MonoJavaBridge.MethodId _readInt19077;
		public virtual int readInt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInputStream._readInt19077);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readInt19077);
		}
		internal static global::MonoJavaBridge.MethodId _readFields19078;
		public virtual global::java.io.ObjectInputStream.GetField readFields() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream._readFields19078)) as java.io.ObjectInputStream.GetField;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readFields19078)) as java.io.ObjectInputStream.GetField;
		}
		internal static global::MonoJavaBridge.MethodId _readChar19079;
		public virtual char readChar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.io.ObjectInputStream._readChar19079);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readChar19079);
		}
		internal static global::MonoJavaBridge.MethodId _read19080;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInputStream._read19080);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._read19080);
		}
		internal static global::MonoJavaBridge.MethodId _read19081;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInputStream._read19081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._read19081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _available19082;
		public override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInputStream._available19082);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._available19082);
		}
		internal static global::MonoJavaBridge.MethodId _readUTF19083;
		public virtual global::java.lang.String readUTF() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream._readUTF19083)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readUTF19083)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readFully19084;
		public virtual void readFully(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream._readFully19084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readFully19084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _readFully19085;
		public virtual void readFully(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream._readFully19085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readFully19085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readLong19086;
		public virtual long readLong() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.ObjectInputStream._readLong19086);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readLong19086);
		}
		internal static global::MonoJavaBridge.MethodId _readByte19087;
		public virtual byte readByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.io.ObjectInputStream._readByte19087);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readByte19087);
		}
		internal static global::MonoJavaBridge.MethodId _readShort19088;
		public virtual short readShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.io.ObjectInputStream._readShort19088);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readShort19088);
		}
		internal static global::MonoJavaBridge.MethodId _readFloat19089;
		public virtual float readFloat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.io.ObjectInputStream._readFloat19089);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readFloat19089);
		}
		internal static global::MonoJavaBridge.MethodId _skipBytes19090;
		public virtual int skipBytes(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInputStream._skipBytes19090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._skipBytes19090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readBoolean19091;
		public virtual bool readBoolean() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.ObjectInputStream._readBoolean19091);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readBoolean19091);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedByte19092;
		public virtual int readUnsignedByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInputStream._readUnsignedByte19092);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readUnsignedByte19092);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedShort19093;
		public virtual int readUnsignedShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInputStream._readUnsignedShort19093);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readUnsignedShort19093);
		}
		internal static global::MonoJavaBridge.MethodId _readDouble19094;
		public virtual double readDouble() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.io.ObjectInputStream._readDouble19094);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readDouble19094);
		}
		internal static global::MonoJavaBridge.MethodId _readObjectOverride19095;
		protected virtual global::java.lang.Object readObjectOverride() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream._readObjectOverride19095)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readObjectOverride19095)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _readUnshared19096;
		public virtual global::java.lang.Object readUnshared() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream._readUnshared19096)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readUnshared19096)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _registerValidation19097;
		public virtual void registerValidation(java.io.ObjectInputValidation arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream._registerValidation19097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._registerValidation19097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _resolveProxyClass19098;
		protected virtual global::java.lang.Class resolveProxyClass(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream._resolveProxyClass19098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._resolveProxyClass19098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _resolveObject19099;
		protected virtual global::java.lang.Object resolveObject(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream._resolveObject19099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._resolveObject19099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _enableResolveObject19100;
		protected virtual bool enableResolveObject(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.ObjectInputStream._enableResolveObject19100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._enableResolveObject19100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readStreamHeader19101;
		protected virtual void readStreamHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream._readStreamHeader19101);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readStreamHeader19101);
		}
		internal static global::MonoJavaBridge.MethodId _readClassDescriptor19102;
		protected virtual global::java.io.ObjectStreamClass readClassDescriptor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream._readClassDescriptor19102)) as java.io.ObjectStreamClass;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readClassDescriptor19102)) as java.io.ObjectStreamClass;
		}
		internal static global::MonoJavaBridge.MethodId _ObjectInputStream19103;
		public ObjectInputStream(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._ObjectInputStream19103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ObjectInputStream19104;
		protected ObjectInputStream()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._ObjectInputStream19104);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ObjectInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectInputStream"));
			global::java.io.ObjectInputStream._resolveClass19072 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "resolveClass", "(Ljava/io/ObjectStreamClass;)Ljava/lang/Class;");
			global::java.io.ObjectInputStream._readLine19073 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readLine", "()Ljava/lang/String;");
			global::java.io.ObjectInputStream._close19074 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "close", "()V");
			global::java.io.ObjectInputStream._readObject19075 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readObject", "()Ljava/lang/Object;");
			global::java.io.ObjectInputStream._defaultReadObject19076 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "defaultReadObject", "()V");
			global::java.io.ObjectInputStream._readInt19077 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readInt", "()I");
			global::java.io.ObjectInputStream._readFields19078 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readFields", "()Ljava/io/ObjectInputStream$GetField;");
			global::java.io.ObjectInputStream._readChar19079 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readChar", "()C");
			global::java.io.ObjectInputStream._read19080 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "read", "()I");
			global::java.io.ObjectInputStream._read19081 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "read", "([BII)I");
			global::java.io.ObjectInputStream._available19082 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "available", "()I");
			global::java.io.ObjectInputStream._readUTF19083 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readUTF", "()Ljava/lang/String;");
			global::java.io.ObjectInputStream._readFully19084 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readFully", "([BII)V");
			global::java.io.ObjectInputStream._readFully19085 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readFully", "([B)V");
			global::java.io.ObjectInputStream._readLong19086 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readLong", "()J");
			global::java.io.ObjectInputStream._readByte19087 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readByte", "()B");
			global::java.io.ObjectInputStream._readShort19088 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readShort", "()S");
			global::java.io.ObjectInputStream._readFloat19089 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readFloat", "()F");
			global::java.io.ObjectInputStream._skipBytes19090 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "skipBytes", "(I)I");
			global::java.io.ObjectInputStream._readBoolean19091 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readBoolean", "()Z");
			global::java.io.ObjectInputStream._readUnsignedByte19092 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readUnsignedByte", "()I");
			global::java.io.ObjectInputStream._readUnsignedShort19093 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readUnsignedShort", "()I");
			global::java.io.ObjectInputStream._readDouble19094 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readDouble", "()D");
			global::java.io.ObjectInputStream._readObjectOverride19095 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readObjectOverride", "()Ljava/lang/Object;");
			global::java.io.ObjectInputStream._readUnshared19096 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readUnshared", "()Ljava/lang/Object;");
			global::java.io.ObjectInputStream._registerValidation19097 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "registerValidation", "(Ljava/io/ObjectInputValidation;I)V");
			global::java.io.ObjectInputStream._resolveProxyClass19098 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "resolveProxyClass", "([Ljava/lang/String;)Ljava/lang/Class;");
			global::java.io.ObjectInputStream._resolveObject19099 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "resolveObject", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.io.ObjectInputStream._enableResolveObject19100 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "enableResolveObject", "(Z)Z");
			global::java.io.ObjectInputStream._readStreamHeader19101 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readStreamHeader", "()V");
			global::java.io.ObjectInputStream._readClassDescriptor19102 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readClassDescriptor", "()Ljava/io/ObjectStreamClass;");
			global::java.io.ObjectInputStream._ObjectInputStream19103 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::java.io.ObjectInputStream._ObjectInputStream19104 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "<init>", "()V");
		}
	}
}
