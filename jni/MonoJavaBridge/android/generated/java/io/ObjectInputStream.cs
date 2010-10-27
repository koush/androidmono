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
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectInputStream.GetField.staticClass, global::java.io.ObjectInputStream.GetField._GetField19178);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.io.ObjectInputStream.GetField.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectInputStream$GetField"));
				global::java.io.ObjectInputStream.GetField._get19167 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "get", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;");
				global::java.io.ObjectInputStream.GetField._get19168 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "get", "(Ljava/lang/String;F)F");
				global::java.io.ObjectInputStream.GetField._get19169 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "get", "(Ljava/lang/String;D)D");
				global::java.io.ObjectInputStream.GetField._get19170 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "get", "(Ljava/lang/String;Z)Z");
				global::java.io.ObjectInputStream.GetField._get19171 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "get", "(Ljava/lang/String;B)B");
				global::java.io.ObjectInputStream.GetField._get19172 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "get", "(Ljava/lang/String;C)C");
				global::java.io.ObjectInputStream.GetField._get19173 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "get", "(Ljava/lang/String;S)S");
				global::java.io.ObjectInputStream.GetField._get19174 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "get", "(Ljava/lang/String;I)I");
				global::java.io.ObjectInputStream.GetField._get19175 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "get", "(Ljava/lang/String;J)J");
				global::java.io.ObjectInputStream.GetField._defaulted19176 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "defaulted", "(Ljava/lang/String;)Z");
				global::java.io.ObjectInputStream.GetField._getObjectStreamClass19177 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "getObjectStreamClass", "()Ljava/io/ObjectStreamClass;");
				global::java.io.ObjectInputStream.GetField._GetField19178 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "<init>", "()V");
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.ObjectInputStream.GetField))]
		internal sealed partial class GetField_ : java.io.ObjectInputStream.GetField
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static GetField_()
			{
				InitJNI();
			}
			internal GetField_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _get19179;
			public override global::java.lang.Object get(java.lang.String arg0, java.lang.Object arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._get19179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._get19179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			}
			internal static global::MonoJavaBridge.MethodId _get19180;
			public override float get(java.lang.String arg0, float arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallFloatMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._get19180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._get19180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _get19181;
			public override double get(java.lang.String arg0, double arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallDoubleMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._get19181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._get19181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _get19182;
			public override bool get(java.lang.String arg0, bool arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._get19182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._get19182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _get19183;
			public override byte get(java.lang.String arg0, byte arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallByteMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._get19183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._get19183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _get19184;
			public override char get(java.lang.String arg0, char arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallCharMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._get19184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._get19184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _get19185;
			public override short get(java.lang.String arg0, short arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallShortMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._get19185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._get19185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _get19186;
			public override int get(java.lang.String arg0, int arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._get19186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._get19186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _get19187;
			public override long get(java.lang.String arg0, long arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._get19187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._get19187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _defaulted19188;
			public override bool defaulted(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._defaulted19188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._defaulted19188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _getObjectStreamClass19189;
			public override global::java.io.ObjectStreamClass getObjectStreamClass()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._getObjectStreamClass19189)) as java.io.ObjectStreamClass;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._getObjectStreamClass19189)) as java.io.ObjectStreamClass;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.io.ObjectInputStream.GetField_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectInputStream$GetField"));
				global::java.io.ObjectInputStream.GetField_._get19179 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;");
				global::java.io.ObjectInputStream.GetField_._get19180 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;F)F");
				global::java.io.ObjectInputStream.GetField_._get19181 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;D)D");
				global::java.io.ObjectInputStream.GetField_._get19182 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;Z)Z");
				global::java.io.ObjectInputStream.GetField_._get19183 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;B)B");
				global::java.io.ObjectInputStream.GetField_._get19184 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;C)C");
				global::java.io.ObjectInputStream.GetField_._get19185 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;S)S");
				global::java.io.ObjectInputStream.GetField_._get19186 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;I)I");
				global::java.io.ObjectInputStream.GetField_._get19187 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;J)J");
				global::java.io.ObjectInputStream.GetField_._defaulted19188 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "defaulted", "(Ljava/lang/String;)Z");
				global::java.io.ObjectInputStream.GetField_._getObjectStreamClass19189 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "getObjectStreamClass", "()Ljava/io/ObjectStreamClass;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _resolveClass19190;
		protected virtual global::java.lang.Class resolveClass(java.io.ObjectStreamClass arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream._resolveClass19190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._resolveClass19190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _readLine19191;
		public virtual global::java.lang.String readLine()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream._readLine19191)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readLine19191)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close19192;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream._close19192);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._close19192);
		}
		internal static global::MonoJavaBridge.MethodId _readObject19193;
		public virtual global::java.lang.Object readObject()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream._readObject19193)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readObject19193)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _defaultReadObject19194;
		public virtual void defaultReadObject()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream._defaultReadObject19194);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._defaultReadObject19194);
		}
		internal static global::MonoJavaBridge.MethodId _readInt19195;
		public virtual int readInt()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInputStream._readInt19195);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readInt19195);
		}
		internal static global::MonoJavaBridge.MethodId _readFields19196;
		public virtual global::java.io.ObjectInputStream.GetField readFields()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream._readFields19196)) as java.io.ObjectInputStream.GetField;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readFields19196)) as java.io.ObjectInputStream.GetField;
		}
		internal static global::MonoJavaBridge.MethodId _readChar19197;
		public virtual char readChar()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.io.ObjectInputStream._readChar19197);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readChar19197);
		}
		internal static global::MonoJavaBridge.MethodId _read19198;
		public override int read()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInputStream._read19198);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._read19198);
		}
		internal static global::MonoJavaBridge.MethodId _read19199;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInputStream._read19199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._read19199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _available19200;
		public override int available()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInputStream._available19200);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._available19200);
		}
		internal static global::MonoJavaBridge.MethodId _readUTF19201;
		public virtual global::java.lang.String readUTF()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream._readUTF19201)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readUTF19201)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readFully19202;
		public virtual void readFully(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream._readFully19202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readFully19202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _readFully19203;
		public virtual void readFully(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream._readFully19203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readFully19203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readLong19204;
		public virtual long readLong()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.ObjectInputStream._readLong19204);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readLong19204);
		}
		internal static global::MonoJavaBridge.MethodId _readByte19205;
		public virtual byte readByte()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.io.ObjectInputStream._readByte19205);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readByte19205);
		}
		internal static global::MonoJavaBridge.MethodId _readShort19206;
		public virtual short readShort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.io.ObjectInputStream._readShort19206);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readShort19206);
		}
		internal static global::MonoJavaBridge.MethodId _readFloat19207;
		public virtual float readFloat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.io.ObjectInputStream._readFloat19207);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readFloat19207);
		}
		internal static global::MonoJavaBridge.MethodId _skipBytes19208;
		public virtual int skipBytes(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInputStream._skipBytes19208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._skipBytes19208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readBoolean19209;
		public virtual bool readBoolean()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.ObjectInputStream._readBoolean19209);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readBoolean19209);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedByte19210;
		public virtual int readUnsignedByte()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInputStream._readUnsignedByte19210);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readUnsignedByte19210);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedShort19211;
		public virtual int readUnsignedShort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInputStream._readUnsignedShort19211);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readUnsignedShort19211);
		}
		internal static global::MonoJavaBridge.MethodId _readDouble19212;
		public virtual double readDouble()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.io.ObjectInputStream._readDouble19212);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readDouble19212);
		}
		internal static global::MonoJavaBridge.MethodId _readObjectOverride19213;
		protected virtual global::java.lang.Object readObjectOverride()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream._readObjectOverride19213)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readObjectOverride19213)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _readUnshared19214;
		public virtual global::java.lang.Object readUnshared()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream._readUnshared19214)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readUnshared19214)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _registerValidation19215;
		public virtual void registerValidation(java.io.ObjectInputValidation arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream._registerValidation19215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._registerValidation19215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _resolveProxyClass19216;
		protected virtual global::java.lang.Class resolveProxyClass(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream._resolveProxyClass19216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._resolveProxyClass19216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _resolveObject19217;
		protected virtual global::java.lang.Object resolveObject(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream._resolveObject19217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._resolveObject19217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _enableResolveObject19218;
		protected virtual bool enableResolveObject(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.ObjectInputStream._enableResolveObject19218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._enableResolveObject19218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readStreamHeader19219;
		protected virtual void readStreamHeader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream._readStreamHeader19219);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readStreamHeader19219);
		}
		internal static global::MonoJavaBridge.MethodId _readClassDescriptor19220;
		protected virtual global::java.io.ObjectStreamClass readClassDescriptor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream._readClassDescriptor19220)) as java.io.ObjectStreamClass;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readClassDescriptor19220)) as java.io.ObjectStreamClass;
		}
		internal static global::MonoJavaBridge.MethodId _ObjectInputStream19221;
		public ObjectInputStream(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._ObjectInputStream19221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ObjectInputStream19222;
		protected ObjectInputStream() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._ObjectInputStream19222);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ObjectInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectInputStream"));
			global::java.io.ObjectInputStream._resolveClass19190 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "resolveClass", "(Ljava/io/ObjectStreamClass;)Ljava/lang/Class;");
			global::java.io.ObjectInputStream._readLine19191 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readLine", "()Ljava/lang/String;");
			global::java.io.ObjectInputStream._close19192 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "close", "()V");
			global::java.io.ObjectInputStream._readObject19193 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readObject", "()Ljava/lang/Object;");
			global::java.io.ObjectInputStream._defaultReadObject19194 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "defaultReadObject", "()V");
			global::java.io.ObjectInputStream._readInt19195 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readInt", "()I");
			global::java.io.ObjectInputStream._readFields19196 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readFields", "()Ljava/io/ObjectInputStream$GetField;");
			global::java.io.ObjectInputStream._readChar19197 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readChar", "()C");
			global::java.io.ObjectInputStream._read19198 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "read", "()I");
			global::java.io.ObjectInputStream._read19199 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "read", "([BII)I");
			global::java.io.ObjectInputStream._available19200 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "available", "()I");
			global::java.io.ObjectInputStream._readUTF19201 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readUTF", "()Ljava/lang/String;");
			global::java.io.ObjectInputStream._readFully19202 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readFully", "([BII)V");
			global::java.io.ObjectInputStream._readFully19203 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readFully", "([B)V");
			global::java.io.ObjectInputStream._readLong19204 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readLong", "()J");
			global::java.io.ObjectInputStream._readByte19205 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readByte", "()B");
			global::java.io.ObjectInputStream._readShort19206 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readShort", "()S");
			global::java.io.ObjectInputStream._readFloat19207 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readFloat", "()F");
			global::java.io.ObjectInputStream._skipBytes19208 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "skipBytes", "(I)I");
			global::java.io.ObjectInputStream._readBoolean19209 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readBoolean", "()Z");
			global::java.io.ObjectInputStream._readUnsignedByte19210 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readUnsignedByte", "()I");
			global::java.io.ObjectInputStream._readUnsignedShort19211 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readUnsignedShort", "()I");
			global::java.io.ObjectInputStream._readDouble19212 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readDouble", "()D");
			global::java.io.ObjectInputStream._readObjectOverride19213 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readObjectOverride", "()Ljava/lang/Object;");
			global::java.io.ObjectInputStream._readUnshared19214 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readUnshared", "()Ljava/lang/Object;");
			global::java.io.ObjectInputStream._registerValidation19215 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "registerValidation", "(Ljava/io/ObjectInputValidation;I)V");
			global::java.io.ObjectInputStream._resolveProxyClass19216 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "resolveProxyClass", "([Ljava/lang/String;)Ljava/lang/Class;");
			global::java.io.ObjectInputStream._resolveObject19217 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "resolveObject", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.io.ObjectInputStream._enableResolveObject19218 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "enableResolveObject", "(Z)Z");
			global::java.io.ObjectInputStream._readStreamHeader19219 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readStreamHeader", "()V");
			global::java.io.ObjectInputStream._readClassDescriptor19220 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readClassDescriptor", "()Ljava/io/ObjectStreamClass;");
			global::java.io.ObjectInputStream._ObjectInputStream19221 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::java.io.ObjectInputStream._ObjectInputStream19222 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "<init>", "()V");
		}
	}
}
