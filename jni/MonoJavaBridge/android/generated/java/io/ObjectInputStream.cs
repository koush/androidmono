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
			internal static global::MonoJavaBridge.MethodId _get13574;
			public abstract global::java.lang.Object get(java.lang.String arg0, java.lang.Object arg1);
			internal static global::MonoJavaBridge.MethodId _get13575;
			public abstract float get(java.lang.String arg0, float arg1);
			internal static global::MonoJavaBridge.MethodId _get13576;
			public abstract double get(java.lang.String arg0, double arg1);
			internal static global::MonoJavaBridge.MethodId _get13577;
			public abstract bool get(java.lang.String arg0, bool arg1);
			internal static global::MonoJavaBridge.MethodId _get13578;
			public abstract byte get(java.lang.String arg0, byte arg1);
			internal static global::MonoJavaBridge.MethodId _get13579;
			public abstract char get(java.lang.String arg0, char arg1);
			internal static global::MonoJavaBridge.MethodId _get13580;
			public abstract short get(java.lang.String arg0, short arg1);
			internal static global::MonoJavaBridge.MethodId _get13581;
			public abstract int get(java.lang.String arg0, int arg1);
			internal static global::MonoJavaBridge.MethodId _get13582;
			public abstract long get(java.lang.String arg0, long arg1);
			internal static global::MonoJavaBridge.MethodId _defaulted13583;
			public abstract bool defaulted(java.lang.String arg0);
			internal static global::MonoJavaBridge.MethodId _getObjectStreamClass13584;
			public abstract global::java.io.ObjectStreamClass getObjectStreamClass();
			internal static global::MonoJavaBridge.MethodId _GetField13585;
			public GetField()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectInputStream.GetField.staticClass, global::java.io.ObjectInputStream.GetField._GetField13585);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.io.ObjectInputStream.GetField.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectInputStream$GetField"));
				global::java.io.ObjectInputStream.GetField._get13574 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "get", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;");
				global::java.io.ObjectInputStream.GetField._get13575 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "get", "(Ljava/lang/String;F)F");
				global::java.io.ObjectInputStream.GetField._get13576 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "get", "(Ljava/lang/String;D)D");
				global::java.io.ObjectInputStream.GetField._get13577 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "get", "(Ljava/lang/String;Z)Z");
				global::java.io.ObjectInputStream.GetField._get13578 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "get", "(Ljava/lang/String;B)B");
				global::java.io.ObjectInputStream.GetField._get13579 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "get", "(Ljava/lang/String;C)C");
				global::java.io.ObjectInputStream.GetField._get13580 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "get", "(Ljava/lang/String;S)S");
				global::java.io.ObjectInputStream.GetField._get13581 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "get", "(Ljava/lang/String;I)I");
				global::java.io.ObjectInputStream.GetField._get13582 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "get", "(Ljava/lang/String;J)J");
				global::java.io.ObjectInputStream.GetField._defaulted13583 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "defaulted", "(Ljava/lang/String;)Z");
				global::java.io.ObjectInputStream.GetField._getObjectStreamClass13584 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "getObjectStreamClass", "()Ljava/io/ObjectStreamClass;");
				global::java.io.ObjectInputStream.GetField._GetField13585 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField.staticClass, "<init>", "()V");
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
			internal static global::MonoJavaBridge.MethodId _get13586;
			public override global::java.lang.Object get(java.lang.String arg0, java.lang.Object arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._get13586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._get13586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			}
			internal static global::MonoJavaBridge.MethodId _get13587;
			public override float get(java.lang.String arg0, float arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallFloatMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._get13587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._get13587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _get13588;
			public override double get(java.lang.String arg0, double arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallDoubleMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._get13588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._get13588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _get13589;
			public override bool get(java.lang.String arg0, bool arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._get13589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._get13589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _get13590;
			public override byte get(java.lang.String arg0, byte arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallByteMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._get13590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._get13590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _get13591;
			public override char get(java.lang.String arg0, char arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallCharMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._get13591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._get13591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _get13592;
			public override short get(java.lang.String arg0, short arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallShortMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._get13592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._get13592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _get13593;
			public override int get(java.lang.String arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._get13593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._get13593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _get13594;
			public override long get(java.lang.String arg0, long arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._get13594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._get13594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _defaulted13595;
			public override bool defaulted(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._defaulted13595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._defaulted13595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _getObjectStreamClass13596;
			public override global::java.io.ObjectStreamClass getObjectStreamClass() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_._getObjectStreamClass13596)) as java.io.ObjectStreamClass;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.GetField_.staticClass, global::java.io.ObjectInputStream.GetField_._getObjectStreamClass13596)) as java.io.ObjectStreamClass;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.io.ObjectInputStream.GetField_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectInputStream$GetField"));
				global::java.io.ObjectInputStream.GetField_._get13586 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;");
				global::java.io.ObjectInputStream.GetField_._get13587 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;F)F");
				global::java.io.ObjectInputStream.GetField_._get13588 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;D)D");
				global::java.io.ObjectInputStream.GetField_._get13589 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;Z)Z");
				global::java.io.ObjectInputStream.GetField_._get13590 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;B)B");
				global::java.io.ObjectInputStream.GetField_._get13591 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;C)C");
				global::java.io.ObjectInputStream.GetField_._get13592 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;S)S");
				global::java.io.ObjectInputStream.GetField_._get13593 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;I)I");
				global::java.io.ObjectInputStream.GetField_._get13594 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "get", "(Ljava/lang/String;J)J");
				global::java.io.ObjectInputStream.GetField_._defaulted13595 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "defaulted", "(Ljava/lang/String;)Z");
				global::java.io.ObjectInputStream.GetField_._getObjectStreamClass13596 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.GetField_.staticClass, "getObjectStreamClass", "()Ljava/io/ObjectStreamClass;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _resolveClass13597;
		protected virtual global::java.lang.Class resolveClass(java.io.ObjectStreamClass arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream._resolveClass13597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._resolveClass13597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _readLine13598;
		public virtual global::java.lang.String readLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream._readLine13598)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readLine13598)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close13599;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream._close13599);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._close13599);
		}
		internal static global::MonoJavaBridge.MethodId _readObject13600;
		public virtual global::java.lang.Object readObject() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream._readObject13600)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readObject13600)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _defaultReadObject13601;
		public virtual void defaultReadObject() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream._defaultReadObject13601);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._defaultReadObject13601);
		}
		internal static global::MonoJavaBridge.MethodId _readInt13602;
		public virtual int readInt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInputStream._readInt13602);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readInt13602);
		}
		internal static global::MonoJavaBridge.MethodId _readFields13603;
		public virtual global::java.io.ObjectInputStream.GetField readFields() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream._readFields13603)) as java.io.ObjectInputStream.GetField;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readFields13603)) as java.io.ObjectInputStream.GetField;
		}
		internal static global::MonoJavaBridge.MethodId _readChar13604;
		public virtual char readChar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.io.ObjectInputStream._readChar13604);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readChar13604);
		}
		internal static global::MonoJavaBridge.MethodId _read13605;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInputStream._read13605);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._read13605);
		}
		internal static global::MonoJavaBridge.MethodId _read13606;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInputStream._read13606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._read13606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _available13607;
		public override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInputStream._available13607);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._available13607);
		}
		internal static global::MonoJavaBridge.MethodId _readUTF13608;
		public virtual global::java.lang.String readUTF() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream._readUTF13608)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readUTF13608)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readFully13609;
		public virtual void readFully(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream._readFully13609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readFully13609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _readFully13610;
		public virtual void readFully(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream._readFully13610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readFully13610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readLong13611;
		public virtual long readLong() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.ObjectInputStream._readLong13611);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readLong13611);
		}
		internal static global::MonoJavaBridge.MethodId _readByte13612;
		public virtual byte readByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.io.ObjectInputStream._readByte13612);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readByte13612);
		}
		internal static global::MonoJavaBridge.MethodId _readShort13613;
		public virtual short readShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.io.ObjectInputStream._readShort13613);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readShort13613);
		}
		internal static global::MonoJavaBridge.MethodId _readFloat13614;
		public virtual float readFloat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.io.ObjectInputStream._readFloat13614);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readFloat13614);
		}
		internal static global::MonoJavaBridge.MethodId _skipBytes13615;
		public virtual int skipBytes(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInputStream._skipBytes13615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._skipBytes13615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readBoolean13616;
		public virtual bool readBoolean() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.ObjectInputStream._readBoolean13616);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readBoolean13616);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedByte13617;
		public virtual int readUnsignedByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInputStream._readUnsignedByte13617);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readUnsignedByte13617);
		}
		internal static global::MonoJavaBridge.MethodId _readUnsignedShort13618;
		public virtual int readUnsignedShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectInputStream._readUnsignedShort13618);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readUnsignedShort13618);
		}
		internal static global::MonoJavaBridge.MethodId _readDouble13619;
		public virtual double readDouble() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.io.ObjectInputStream._readDouble13619);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readDouble13619);
		}
		internal static global::MonoJavaBridge.MethodId _readObjectOverride13620;
		protected virtual global::java.lang.Object readObjectOverride() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream._readObjectOverride13620)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readObjectOverride13620)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _readUnshared13621;
		public virtual global::java.lang.Object readUnshared() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream._readUnshared13621)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readUnshared13621)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _registerValidation13622;
		public virtual void registerValidation(java.io.ObjectInputValidation arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream._registerValidation13622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._registerValidation13622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _resolveProxyClass13623;
		protected virtual global::java.lang.Class resolveProxyClass(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream._resolveProxyClass13623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._resolveProxyClass13623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _resolveObject13624;
		protected virtual global::java.lang.Object resolveObject(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream._resolveObject13624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._resolveObject13624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _enableResolveObject13625;
		protected virtual bool enableResolveObject(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.ObjectInputStream._enableResolveObject13625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._enableResolveObject13625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readStreamHeader13626;
		protected virtual void readStreamHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream._readStreamHeader13626);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readStreamHeader13626);
		}
		internal static global::MonoJavaBridge.MethodId _readClassDescriptor13627;
		protected virtual global::java.io.ObjectStreamClass readClassDescriptor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream._readClassDescriptor13627)) as java.io.ObjectStreamClass;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._readClassDescriptor13627)) as java.io.ObjectStreamClass;
		}
		internal static global::MonoJavaBridge.MethodId _ObjectInputStream13628;
		public ObjectInputStream(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._ObjectInputStream13628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ObjectInputStream13629;
		protected ObjectInputStream()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectInputStream.staticClass, global::java.io.ObjectInputStream._ObjectInputStream13629);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ObjectInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectInputStream"));
			global::java.io.ObjectInputStream._resolveClass13597 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "resolveClass", "(Ljava/io/ObjectStreamClass;)Ljava/lang/Class;");
			global::java.io.ObjectInputStream._readLine13598 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readLine", "()Ljava/lang/String;");
			global::java.io.ObjectInputStream._close13599 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "close", "()V");
			global::java.io.ObjectInputStream._readObject13600 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readObject", "()Ljava/lang/Object;");
			global::java.io.ObjectInputStream._defaultReadObject13601 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "defaultReadObject", "()V");
			global::java.io.ObjectInputStream._readInt13602 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readInt", "()I");
			global::java.io.ObjectInputStream._readFields13603 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readFields", "()Ljava/io/ObjectInputStream$GetField;");
			global::java.io.ObjectInputStream._readChar13604 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readChar", "()C");
			global::java.io.ObjectInputStream._read13605 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "read", "()I");
			global::java.io.ObjectInputStream._read13606 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "read", "([BII)I");
			global::java.io.ObjectInputStream._available13607 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "available", "()I");
			global::java.io.ObjectInputStream._readUTF13608 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readUTF", "()Ljava/lang/String;");
			global::java.io.ObjectInputStream._readFully13609 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readFully", "([BII)V");
			global::java.io.ObjectInputStream._readFully13610 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readFully", "([B)V");
			global::java.io.ObjectInputStream._readLong13611 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readLong", "()J");
			global::java.io.ObjectInputStream._readByte13612 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readByte", "()B");
			global::java.io.ObjectInputStream._readShort13613 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readShort", "()S");
			global::java.io.ObjectInputStream._readFloat13614 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readFloat", "()F");
			global::java.io.ObjectInputStream._skipBytes13615 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "skipBytes", "(I)I");
			global::java.io.ObjectInputStream._readBoolean13616 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readBoolean", "()Z");
			global::java.io.ObjectInputStream._readUnsignedByte13617 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readUnsignedByte", "()I");
			global::java.io.ObjectInputStream._readUnsignedShort13618 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readUnsignedShort", "()I");
			global::java.io.ObjectInputStream._readDouble13619 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readDouble", "()D");
			global::java.io.ObjectInputStream._readObjectOverride13620 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readObjectOverride", "()Ljava/lang/Object;");
			global::java.io.ObjectInputStream._readUnshared13621 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readUnshared", "()Ljava/lang/Object;");
			global::java.io.ObjectInputStream._registerValidation13622 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "registerValidation", "(Ljava/io/ObjectInputValidation;I)V");
			global::java.io.ObjectInputStream._resolveProxyClass13623 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "resolveProxyClass", "([Ljava/lang/String;)Ljava/lang/Class;");
			global::java.io.ObjectInputStream._resolveObject13624 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "resolveObject", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.io.ObjectInputStream._enableResolveObject13625 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "enableResolveObject", "(Z)Z");
			global::java.io.ObjectInputStream._readStreamHeader13626 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readStreamHeader", "()V");
			global::java.io.ObjectInputStream._readClassDescriptor13627 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "readClassDescriptor", "()Ljava/io/ObjectStreamClass;");
			global::java.io.ObjectInputStream._ObjectInputStream13628 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::java.io.ObjectInputStream._ObjectInputStream13629 = @__env.GetMethodIDNoThrow(global::java.io.ObjectInputStream.staticClass, "<init>", "()V");
		}
	}
}
