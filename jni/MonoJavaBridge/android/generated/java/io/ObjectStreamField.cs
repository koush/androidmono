namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ObjectStreamField : java.lang.Object, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ObjectStreamField()
		{
			InitJNI();
		}
		protected ObjectStreamField(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString19338;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectStreamField._toString19338)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectStreamField.staticClass, global::java.io.ObjectStreamField._toString19338)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isPrimitive19339;
		public virtual bool isPrimitive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.ObjectStreamField._isPrimitive19339);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.ObjectStreamField.staticClass, global::java.io.ObjectStreamField._isPrimitive19339);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo19340;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectStreamField._compareTo19340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectStreamField.staticClass, global::java.io.ObjectStreamField._compareTo19340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName19341;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectStreamField._getName19341)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectStreamField.staticClass, global::java.io.ObjectStreamField._getName19341)) as java.lang.String;
		}
		public new global::java.lang.Class Type
		{
			get
			{
				return getType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getType19342;
		public virtual global::java.lang.Class getType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectStreamField._getType19342)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectStreamField.staticClass, global::java.io.ObjectStreamField._getType19342)) as java.lang.Class;
		}
		public new char TypeCode
		{
			get
			{
				return getTypeCode();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTypeCode19343;
		public virtual char getTypeCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.io.ObjectStreamField._getTypeCode19343);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.io.ObjectStreamField.staticClass, global::java.io.ObjectStreamField._getTypeCode19343);
		}
		public new global::java.lang.String TypeString
		{
			get
			{
				return getTypeString();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTypeString19344;
		public virtual global::java.lang.String getTypeString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.ObjectStreamField._getTypeString19344)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.ObjectStreamField.staticClass, global::java.io.ObjectStreamField._getTypeString19344)) as java.lang.String;
		}
		public new int Offset
		{
			get
			{
				return getOffset();
			}
			set
			{
				setOffset(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOffset19345;
		public virtual int getOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.ObjectStreamField._getOffset19345);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.ObjectStreamField.staticClass, global::java.io.ObjectStreamField._getOffset19345);
		}
		internal static global::MonoJavaBridge.MethodId _setOffset19346;
		protected virtual void setOffset(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.ObjectStreamField._setOffset19346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.ObjectStreamField.staticClass, global::java.io.ObjectStreamField._setOffset19346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isUnshared19347;
		public virtual bool isUnshared() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.ObjectStreamField._isUnshared19347);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.ObjectStreamField.staticClass, global::java.io.ObjectStreamField._isUnshared19347);
		}
		internal static global::MonoJavaBridge.MethodId _ObjectStreamField19348;
		public ObjectStreamField(java.lang.String arg0, java.lang.Class arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectStreamField.staticClass, global::java.io.ObjectStreamField._ObjectStreamField19348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ObjectStreamField19349;
		public ObjectStreamField(java.lang.String arg0, java.lang.Class arg1, bool arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.ObjectStreamField.staticClass, global::java.io.ObjectStreamField._ObjectStreamField19349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.ObjectStreamField.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/ObjectStreamField"));
			global::java.io.ObjectStreamField._toString19338 = @__env.GetMethodIDNoThrow(global::java.io.ObjectStreamField.staticClass, "toString", "()Ljava/lang/String;");
			global::java.io.ObjectStreamField._isPrimitive19339 = @__env.GetMethodIDNoThrow(global::java.io.ObjectStreamField.staticClass, "isPrimitive", "()Z");
			global::java.io.ObjectStreamField._compareTo19340 = @__env.GetMethodIDNoThrow(global::java.io.ObjectStreamField.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.io.ObjectStreamField._getName19341 = @__env.GetMethodIDNoThrow(global::java.io.ObjectStreamField.staticClass, "getName", "()Ljava/lang/String;");
			global::java.io.ObjectStreamField._getType19342 = @__env.GetMethodIDNoThrow(global::java.io.ObjectStreamField.staticClass, "getType", "()Ljava/lang/Class;");
			global::java.io.ObjectStreamField._getTypeCode19343 = @__env.GetMethodIDNoThrow(global::java.io.ObjectStreamField.staticClass, "getTypeCode", "()C");
			global::java.io.ObjectStreamField._getTypeString19344 = @__env.GetMethodIDNoThrow(global::java.io.ObjectStreamField.staticClass, "getTypeString", "()Ljava/lang/String;");
			global::java.io.ObjectStreamField._getOffset19345 = @__env.GetMethodIDNoThrow(global::java.io.ObjectStreamField.staticClass, "getOffset", "()I");
			global::java.io.ObjectStreamField._setOffset19346 = @__env.GetMethodIDNoThrow(global::java.io.ObjectStreamField.staticClass, "setOffset", "(I)V");
			global::java.io.ObjectStreamField._isUnshared19347 = @__env.GetMethodIDNoThrow(global::java.io.ObjectStreamField.staticClass, "isUnshared", "()Z");
			global::java.io.ObjectStreamField._ObjectStreamField19348 = @__env.GetMethodIDNoThrow(global::java.io.ObjectStreamField.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Class;)V");
			global::java.io.ObjectStreamField._ObjectStreamField19349 = @__env.GetMethodIDNoThrow(global::java.io.ObjectStreamField.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Class;Z)V");
		}
	}
}
