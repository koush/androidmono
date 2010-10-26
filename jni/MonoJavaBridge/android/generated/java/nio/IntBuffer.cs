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
		internal static global::MonoJavaBridge.MethodId _get22241;
		public abstract int get();
		internal static global::MonoJavaBridge.MethodId _get22242;
		public virtual global::java.nio.IntBuffer get(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer._get22242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._get22242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22243;
		public virtual global::java.nio.IntBuffer get(int[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer._get22243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._get22243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22244;
		public abstract int get(int arg0);
		internal static global::MonoJavaBridge.MethodId _put22245;
		public virtual global::java.nio.IntBuffer put(java.nio.IntBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer._put22245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._put22245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22246;
		public abstract global::java.nio.IntBuffer put(int arg0);
		internal static global::MonoJavaBridge.MethodId _put22247;
		public abstract global::java.nio.IntBuffer put(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _put22248;
		public virtual global::java.nio.IntBuffer put(int[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer._put22248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._put22248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22249;
		public virtual global::java.nio.IntBuffer put(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer._put22249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._put22249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _equals22250;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.IntBuffer._equals22250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._equals22250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString22251;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer._toString22251)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._toString22251)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22252;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.IntBuffer._hashCode22252);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._hashCode22252);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22253;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.IntBuffer._compareTo22253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._compareTo22253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22254;
		public virtual int compareTo(java.nio.IntBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.IntBuffer._compareTo22254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._compareTo22254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22255;
		public abstract bool isDirect();
		internal static global::MonoJavaBridge.MethodId _hasArray22256;
		public sealed override bool hasArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.IntBuffer._hasArray22256);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._hasArray22256);
		}
		internal static global::MonoJavaBridge.MethodId _array22257;
		public override global::java.lang.Object array() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer._array22257)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._array22257)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset22258;
		public sealed override int arrayOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.IntBuffer._arrayOffset22258);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._arrayOffset22258);
		}
		internal static global::MonoJavaBridge.MethodId _wrap22259;
		public static global::java.nio.IntBuffer wrap(int[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._wrap22259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap22260;
		public static global::java.nio.IntBuffer wrap(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._wrap22260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _allocate22261;
		public static global::java.nio.IntBuffer allocate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._allocate22261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22262;
		public abstract global::java.nio.IntBuffer duplicate();
		internal static global::MonoJavaBridge.MethodId _slice22263;
		public abstract global::java.nio.IntBuffer slice();
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22264;
		public abstract global::java.nio.IntBuffer asReadOnlyBuffer();
		internal static global::MonoJavaBridge.MethodId _compact22265;
		public abstract global::java.nio.IntBuffer compact();
		internal static global::MonoJavaBridge.MethodId _order22266;
		public abstract global::java.nio.ByteOrder order();
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.IntBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/IntBuffer"));
			global::java.nio.IntBuffer._get22241 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "get", "()I");
			global::java.nio.IntBuffer._get22242 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "get", "([I)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._get22243 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "get", "([III)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._get22244 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "get", "(I)I");
			global::java.nio.IntBuffer._put22245 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "put", "(Ljava/nio/IntBuffer;)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._put22246 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "put", "(I)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._put22247 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "put", "(II)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._put22248 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "put", "([III)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._put22249 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "put", "([I)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._equals22250 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.IntBuffer._toString22251 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.IntBuffer._hashCode22252 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "hashCode", "()I");
			global::java.nio.IntBuffer._compareTo22253 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.IntBuffer._compareTo22254 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "compareTo", "(Ljava/nio/IntBuffer;)I");
			global::java.nio.IntBuffer._isDirect22255 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.IntBuffer._hasArray22256 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "hasArray", "()Z");
			global::java.nio.IntBuffer._array22257 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.IntBuffer._arrayOffset22258 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "arrayOffset", "()I");
			global::java.nio.IntBuffer._wrap22259 = @__env.GetStaticMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "wrap", "([III)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._wrap22260 = @__env.GetStaticMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "wrap", "([I)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._allocate22261 = @__env.GetStaticMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "allocate", "(I)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._duplicate22262 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "duplicate", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._slice22263 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "slice", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._asReadOnlyBuffer22264 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._compact22265 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "compact", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer._order22266 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.IntBuffer))]
	internal sealed partial class IntBuffer_ : java.nio.IntBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IntBuffer_()
		{
			InitJNI();
		}
		internal IntBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get22267;
		public override int get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.IntBuffer_._get22267);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._get22267);
		}
		internal static global::MonoJavaBridge.MethodId _get22268;
		public override int get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.IntBuffer_._get22268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._get22268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put22269;
		public override global::java.nio.IntBuffer put(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_._put22269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._put22269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22270;
		public override global::java.nio.IntBuffer put(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_._put22270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._put22270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22271;
		public override bool isDirect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.IntBuffer_._isDirect22271);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._isDirect22271);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22272;
		public override global::java.nio.IntBuffer duplicate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_._duplicate22272)) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._duplicate22272)) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice22273;
		public override global::java.nio.IntBuffer slice() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_._slice22273)) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._slice22273)) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22274;
		public override global::java.nio.IntBuffer asReadOnlyBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_._asReadOnlyBuffer22274)) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._asReadOnlyBuffer22274)) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact22275;
		public override global::java.nio.IntBuffer compact() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_._compact22275)) as java.nio.IntBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._compact22275)) as java.nio.IntBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _order22276;
		public override global::java.nio.ByteOrder order() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.nio.ByteOrder>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_._order22276)) as java.nio.ByteOrder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.nio.ByteOrder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._order22276)) as java.nio.ByteOrder;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly22277;
		public override bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.IntBuffer_._isReadOnly22277);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.IntBuffer_.staticClass, global::java.nio.IntBuffer_._isReadOnly22277);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.IntBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/IntBuffer"));
			global::java.nio.IntBuffer_._get22267 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "get", "()I");
			global::java.nio.IntBuffer_._get22268 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "get", "(I)I");
			global::java.nio.IntBuffer_._put22269 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "put", "(I)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer_._put22270 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "put", "(II)Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer_._isDirect22271 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "isDirect", "()Z");
			global::java.nio.IntBuffer_._duplicate22272 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "duplicate", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer_._slice22273 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "slice", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer_._asReadOnlyBuffer22274 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer_._compact22275 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "compact", "()Ljava/nio/IntBuffer;");
			global::java.nio.IntBuffer_._order22276 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "order", "()Ljava/nio/ByteOrder;");
			global::java.nio.IntBuffer_._isReadOnly22277 = @__env.GetMethodIDNoThrow(global::java.nio.IntBuffer_.staticClass, "isReadOnly", "()Z");
		}
	}
}
