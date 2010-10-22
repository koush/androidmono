namespace java.nio
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.ShortBuffer_))]
	public abstract partial class ShortBuffer : java.nio.Buffer, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ShortBuffer()
		{
			InitJNI();
		}
		protected ShortBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get22242;
		public abstract short get();
		internal static global::MonoJavaBridge.MethodId _get22243;
		public virtual global::java.nio.ShortBuffer get(short[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer._get22243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._get22243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22244;
		public virtual global::java.nio.ShortBuffer get(short[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer._get22244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._get22244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22245;
		public abstract short get(int arg0);
		internal static global::MonoJavaBridge.MethodId _put22246;
		public virtual global::java.nio.ShortBuffer put(java.nio.ShortBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer._put22246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._put22246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22247;
		public abstract global::java.nio.ShortBuffer put(short arg0);
		internal static global::MonoJavaBridge.MethodId _put22248;
		public abstract global::java.nio.ShortBuffer put(int arg0, short arg1);
		internal static global::MonoJavaBridge.MethodId _put22249;
		public virtual global::java.nio.ShortBuffer put(short[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer._put22249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._put22249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22250;
		public virtual global::java.nio.ShortBuffer put(short[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer._put22250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._put22250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _equals22251;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ShortBuffer._equals22251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._equals22251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString22252;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer._toString22252)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._toString22252)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22253;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ShortBuffer._hashCode22253);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._hashCode22253);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22254;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ShortBuffer._compareTo22254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._compareTo22254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22255;
		public virtual int compareTo(java.nio.ShortBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ShortBuffer._compareTo22255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._compareTo22255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22256;
		public abstract bool isDirect();
		internal static global::MonoJavaBridge.MethodId _hasArray22257;
		public sealed override bool hasArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ShortBuffer._hasArray22257);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._hasArray22257);
		}
		internal static global::MonoJavaBridge.MethodId _array22258;
		public override global::java.lang.Object array() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer._array22258)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._array22258)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset22259;
		public sealed override int arrayOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ShortBuffer._arrayOffset22259);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._arrayOffset22259);
		}
		internal static global::MonoJavaBridge.MethodId _wrap22260;
		public static global::java.nio.ShortBuffer wrap(short[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._wrap22260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap22261;
		public static global::java.nio.ShortBuffer wrap(short[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._wrap22261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _allocate22262;
		public static global::java.nio.ShortBuffer allocate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._allocate22262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22263;
		public abstract global::java.nio.ShortBuffer duplicate();
		internal static global::MonoJavaBridge.MethodId _slice22264;
		public abstract global::java.nio.ShortBuffer slice();
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22265;
		public abstract global::java.nio.ShortBuffer asReadOnlyBuffer();
		internal static global::MonoJavaBridge.MethodId _compact22266;
		public abstract global::java.nio.ShortBuffer compact();
		internal static global::MonoJavaBridge.MethodId _order22267;
		public abstract global::java.nio.ByteOrder order();
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.ShortBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/ShortBuffer"));
			global::java.nio.ShortBuffer._get22242 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "get", "()S");
			global::java.nio.ShortBuffer._get22243 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "get", "([S)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._get22244 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "get", "([SII)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._get22245 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "get", "(I)S");
			global::java.nio.ShortBuffer._put22246 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "put", "(Ljava/nio/ShortBuffer;)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._put22247 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "put", "(S)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._put22248 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "put", "(IS)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._put22249 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "put", "([SII)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._put22250 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "put", "([S)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._equals22251 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.ShortBuffer._toString22252 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.ShortBuffer._hashCode22253 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "hashCode", "()I");
			global::java.nio.ShortBuffer._compareTo22254 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.ShortBuffer._compareTo22255 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "compareTo", "(Ljava/nio/ShortBuffer;)I");
			global::java.nio.ShortBuffer._isDirect22256 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.ShortBuffer._hasArray22257 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "hasArray", "()Z");
			global::java.nio.ShortBuffer._array22258 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.ShortBuffer._arrayOffset22259 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "arrayOffset", "()I");
			global::java.nio.ShortBuffer._wrap22260 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "wrap", "([SII)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._wrap22261 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "wrap", "([S)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._allocate22262 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "allocate", "(I)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._duplicate22263 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "duplicate", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._slice22264 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "slice", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._asReadOnlyBuffer22265 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._compact22266 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "compact", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._order22267 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.ShortBuffer))]
	public sealed partial class ShortBuffer_ : java.nio.ShortBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ShortBuffer_()
		{
			InitJNI();
		}
		internal ShortBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get22268;
		public override short get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.nio.ShortBuffer_._get22268);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._get22268);
		}
		internal static global::MonoJavaBridge.MethodId _get22269;
		public override short get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.nio.ShortBuffer_._get22269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._get22269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put22270;
		public override global::java.nio.ShortBuffer put(short arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_._put22270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._put22270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22271;
		public override global::java.nio.ShortBuffer put(int arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_._put22271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._put22271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22272;
		public override bool isDirect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ShortBuffer_._isDirect22272);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._isDirect22272);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22273;
		public override global::java.nio.ShortBuffer duplicate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_._duplicate22273)) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._duplicate22273)) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice22274;
		public override global::java.nio.ShortBuffer slice() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_._slice22274)) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._slice22274)) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22275;
		public override global::java.nio.ShortBuffer asReadOnlyBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_._asReadOnlyBuffer22275)) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._asReadOnlyBuffer22275)) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact22276;
		public override global::java.nio.ShortBuffer compact() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_._compact22276)) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._compact22276)) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _order22277;
		public override global::java.nio.ByteOrder order() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.nio.ByteOrder>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_._order22277)) as java.nio.ByteOrder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.nio.ByteOrder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._order22277)) as java.nio.ByteOrder;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly22278;
		public override bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ShortBuffer_._isReadOnly22278);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._isReadOnly22278);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.ShortBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/ShortBuffer"));
			global::java.nio.ShortBuffer_._get22268 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "get", "()S");
			global::java.nio.ShortBuffer_._get22269 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "get", "(I)S");
			global::java.nio.ShortBuffer_._put22270 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "put", "(S)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer_._put22271 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "put", "(IS)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer_._isDirect22272 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "isDirect", "()Z");
			global::java.nio.ShortBuffer_._duplicate22273 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "duplicate", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer_._slice22274 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "slice", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer_._asReadOnlyBuffer22275 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer_._compact22276 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "compact", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer_._order22277 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "order", "()Ljava/nio/ByteOrder;");
			global::java.nio.ShortBuffer_._isReadOnly22278 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "isReadOnly", "()Z");
		}
	}
}
