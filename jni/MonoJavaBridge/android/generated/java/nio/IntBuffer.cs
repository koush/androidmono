namespace java.nio
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.IntBuffer_))]
	public abstract partial class IntBuffer : java.nio.Buffer, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IntBuffer()
		{
			InitJNI();
		}
		protected IntBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get22123;
		public abstract int get();
		internal static global::MonoJavaBridge.MethodId _get22124;
		public virtual global::java.nio.IntBuffer get(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer._get22124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._get22124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22125;
		public virtual global::java.nio.IntBuffer get(int[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer._get22125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._get22125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22126;
		public abstract int get(int arg0);
		internal static global::MonoJavaBridge.MethodId _put22127;
		public virtual global::java.nio.IntBuffer put(java.nio.IntBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer._put22127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._put22127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22128;
		public abstract global::java.nio.IntBuffer put(int arg0);
		internal static global::MonoJavaBridge.MethodId _put22129;
		public abstract global::java.nio.IntBuffer put(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _put22130;
		public virtual global::java.nio.IntBuffer put(int[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer._put22130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._put22130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22131;
		public virtual global::java.nio.IntBuffer put(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer._put22131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._put22131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _equals22132;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.IntBuffer._equals22132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._equals22132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString22133;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer._toString22133)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._toString22133)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22134;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.IntBuffer._hashCode22134);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._hashCode22134);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22135;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.IntBuffer._compareTo22135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._compareTo22135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22136;
		public virtual int compareTo(java.nio.IntBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.IntBuffer._compareTo22136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._compareTo22136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22137;
		public abstract bool isDirect();
		internal static global::MonoJavaBridge.MethodId _hasArray22138;
		public sealed override bool hasArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.IntBuffer._hasArray22138);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._hasArray22138);
		}
		internal static global::MonoJavaBridge.MethodId _array22139;
		public override global::java.lang.Object array() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer._array22139)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._array22139)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset22140;
		public sealed override int arrayOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.IntBuffer._arrayOffset22140);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._arrayOffset22140);
		}
		internal static global::MonoJavaBridge.MethodId _wrap22141;
		public static global::java.nio.IntBuffer wrap(int[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._wrap22141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap22142;
		public static global::java.nio.IntBuffer wrap(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._wrap22142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _allocate22143;
		public static global::java.nio.IntBuffer allocate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._allocate22143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22144;
		public abstract global::java.nio.IntBuffer duplicate();
		internal static global::MonoJavaBridge.MethodId _slice22145;
		public abstract global::java.nio.IntBuffer slice();
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22146;
		public abstract global::java.nio.IntBuffer asReadOnlyBuffer();
		internal static global::MonoJavaBridge.MethodId _compact22147;
		public abstract global::java.nio.IntBuffer compact();
		internal static global::MonoJavaBridge.MethodId _order22148;
		public abstract global::java.nio.ByteOrder order();
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.IntBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/IntBuffer"));
			global::java.nio.IntBuffer._get22123 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "get", "()I");
			global::java.nio.IntBuffer._get22124 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "get", "([I)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._get22125 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "get", "([III)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._get22126 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "get", "(I)I");
			global::java.nio.IntBuffer._put22127 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "put", "(Ljava/nio/IntBuffer;)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._put22128 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "put", "(I)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._put22129 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "put", "(II)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._put22130 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "put", "([III)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._put22131 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "put", "([I)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._equals22132 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.IntBuffer._toString22133 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.IntBuffer._hashCode22134 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "hashCode", "()I");
			global::java.nio.IntBuffer._compareTo22135 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.IntBuffer._compareTo22136 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "compareTo", "(Ljava/nio/IntBuffer;)I");
			global::java.nio.IntBuffer._isDirect22137 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.IntBuffer._hasArray22138 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "hasArray", "()Z");
			global::java.nio.IntBuffer._array22139 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.IntBuffer._arrayOffset22140 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "arrayOffset", "()I");
			global::java.nio.IntBuffer._wrap22141 = @__env.GetStaticMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "wrap", "([III)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._wrap22142 = @__env.GetStaticMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "wrap", "([I)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._allocate22143 = @__env.GetStaticMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "allocate", "(I)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._duplicate22144 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "duplicate", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._slice22145 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "slice", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._asReadOnlyBuffer22146 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._compact22147 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "compact", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._order22148 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.IntBuffer))]
	public sealed partial class IntBuffer_ : java.nio.IntBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IntBuffer_()
		{
			InitJNI();
		}
		internal IntBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get22149;
		public override int get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.IntBuffer_._get22149);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._get22149);
		}
		internal static global::MonoJavaBridge.MethodId _get22150;
		public override int get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.IntBuffer_._get22150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._get22150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put22151;
		public override global::java.nio.IntBuffer put(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_._put22151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._put22151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22152;
		public override global::java.nio.IntBuffer put(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_._put22152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._put22152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22153;
		public override bool isDirect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.IntBuffer_._isDirect22153);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._isDirect22153);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22154;
		public override global::java.nio.IntBuffer duplicate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_._duplicate22154)) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._duplicate22154)) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice22155;
		public override global::java.nio.IntBuffer slice() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_._slice22155)) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._slice22155)) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22156;
		public override global::java.nio.IntBuffer asReadOnlyBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_._asReadOnlyBuffer22156)) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._asReadOnlyBuffer22156)) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact22157;
		public override global::java.nio.IntBuffer compact() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_._compact22157)) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._compact22157)) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _order22158;
		public override global::java.nio.ByteOrder order() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.nio.ByteOrder>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_._order22158)) as java.nio.ByteOrder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.nio.ByteOrder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._order22158)) as java.nio.ByteOrder;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly22159;
		public override bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.IntBuffer_._isReadOnly22159);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._isReadOnly22159);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.IntBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/IntBuffer"));
			global::java.nio.IntBuffer_._get22149 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "get", "()I");
			global::java.nio.IntBuffer_._get22150 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "get", "(I)I");
			global::java.nio.IntBuffer_._put22151 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "put", "(I)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer_._put22152 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "put", "(II)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer_._isDirect22153 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "isDirect", "()Z");
			global::java.nio.IntBuffer_._duplicate22154 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "duplicate", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer_._slice22155 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "slice", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer_._asReadOnlyBuffer22156 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer_._compact22157 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "compact", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer_._order22158 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "order", "()Ljava/nio/ByteOrder;");
			global::java.nio.IntBuffer_._isReadOnly22159 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "isReadOnly", "()Z");
		}
	}
}
