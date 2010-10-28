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
		internal static global::MonoJavaBridge.MethodId _get22361;
		public abstract short get();
		internal static global::MonoJavaBridge.MethodId _get22362;
		public virtual global::java.nio.ShortBuffer get(short[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer._get22362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._get22362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22363;
		public virtual global::java.nio.ShortBuffer get(short[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer._get22363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._get22363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _get22364;
		public abstract short get(int arg0);
		internal static global::MonoJavaBridge.MethodId _put22365;
		public virtual global::java.nio.ShortBuffer put(java.nio.ShortBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer._put22365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._put22365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22366;
		public abstract global::java.nio.ShortBuffer put(short arg0);
		internal static global::MonoJavaBridge.MethodId _put22367;
		public abstract global::java.nio.ShortBuffer put(int arg0, short arg1);
		internal static global::MonoJavaBridge.MethodId _put22368;
		public virtual global::java.nio.ShortBuffer put(short[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer._put22368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._put22368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22369;
		public virtual global::java.nio.ShortBuffer put(short[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer._put22369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._put22369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _equals22370;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ShortBuffer._equals22370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._equals22370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString22371;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer._toString22371)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._toString22371)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22372;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ShortBuffer._hashCode22372);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._hashCode22372);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22373;
		public virtual int compareTo(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ShortBuffer._compareTo22373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._compareTo22373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22374;
		public virtual int compareTo(java.nio.ShortBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ShortBuffer._compareTo22374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._compareTo22374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22375;
		public abstract bool isDirect();
		internal static global::MonoJavaBridge.MethodId _hasArray22376;
		public sealed override bool hasArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ShortBuffer._hasArray22376);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._hasArray22376);
		}
		internal static global::MonoJavaBridge.MethodId _array22377;
		public override global::java.lang.Object array()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer._array22377)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._array22377)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset22378;
		public sealed override int arrayOffset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.ShortBuffer._arrayOffset22378);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._arrayOffset22378);
		}
		internal static global::MonoJavaBridge.MethodId _wrap22379;
		public static global::java.nio.ShortBuffer wrap(short[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._wrap22379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _wrap22380;
		public static global::java.nio.ShortBuffer wrap(short[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._wrap22380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _allocate22381;
		public static global::java.nio.ShortBuffer allocate(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ShortBuffer.staticClass, global::java.nio.ShortBuffer._allocate22381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22382;
		public abstract global::java.nio.ShortBuffer duplicate();
		internal static global::MonoJavaBridge.MethodId _slice22383;
		public abstract global::java.nio.ShortBuffer slice();
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22384;
		public abstract global::java.nio.ShortBuffer asReadOnlyBuffer();
		internal static global::MonoJavaBridge.MethodId _compact22385;
		public abstract global::java.nio.ShortBuffer compact();
		internal static global::MonoJavaBridge.MethodId _order22386;
		public abstract global::java.nio.ByteOrder order();
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.ShortBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/ShortBuffer"));
			global::java.nio.ShortBuffer._get22361 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "get", "()S");
			global::java.nio.ShortBuffer._get22362 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "get", "([S)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._get22363 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "get", "([SII)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._get22364 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "get", "(I)S");
			global::java.nio.ShortBuffer._put22365 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "put", "(Ljava/nio/ShortBuffer;)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._put22366 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "put", "(S)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._put22367 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "put", "(IS)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._put22368 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "put", "([SII)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._put22369 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "put", "([S)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._equals22370 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.ShortBuffer._toString22371 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.ShortBuffer._hashCode22372 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "hashCode", "()I");
			global::java.nio.ShortBuffer._compareTo22373 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.ShortBuffer._compareTo22374 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "compareTo", "(Ljava/nio/ShortBuffer;)I");
			global::java.nio.ShortBuffer._isDirect22375 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "isDirect", "()Z");
			global::java.nio.ShortBuffer._hasArray22376 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "hasArray", "()Z");
			global::java.nio.ShortBuffer._array22377 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "array", "()Ljava/lang/Object;");
			global::java.nio.ShortBuffer._arrayOffset22378 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "arrayOffset", "()I");
			global::java.nio.ShortBuffer._wrap22379 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "wrap", "([SII)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._wrap22380 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "wrap", "([S)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._allocate22381 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "allocate", "(I)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._duplicate22382 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "duplicate", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._slice22383 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "slice", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._asReadOnlyBuffer22384 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._compact22385 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "compact", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer._order22386 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.ShortBuffer))]
	internal sealed partial class ShortBuffer_ : java.nio.ShortBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ShortBuffer_()
		{
			InitJNI();
		}
		internal ShortBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get22387;
		public override short get()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.nio.ShortBuffer_._get22387);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._get22387);
		}
		internal static global::MonoJavaBridge.MethodId _get22388;
		public override short get(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.nio.ShortBuffer_._get22388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._get22388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put22389;
		public override global::java.nio.ShortBuffer put(short arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_._put22389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._put22389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _put22390;
		public override global::java.nio.ShortBuffer put(int arg0, short arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_._put22390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._put22390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isDirect22391;
		public override bool isDirect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ShortBuffer_._isDirect22391);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._isDirect22391);
		}
		internal static global::MonoJavaBridge.MethodId _duplicate22392;
		public override global::java.nio.ShortBuffer duplicate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_._duplicate22392)) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._duplicate22392)) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _slice22393;
		public override global::java.nio.ShortBuffer slice()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_._slice22393)) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._slice22393)) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _asReadOnlyBuffer22394;
		public override global::java.nio.ShortBuffer asReadOnlyBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_._asReadOnlyBuffer22394)) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._asReadOnlyBuffer22394)) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _compact22395;
		public override global::java.nio.ShortBuffer compact()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_._compact22395)) as java.nio.ShortBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._compact22395)) as java.nio.ShortBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _order22396;
		public override global::java.nio.ByteOrder order()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.nio.ByteOrder>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_._order22396)) as java.nio.ByteOrder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.nio.ByteOrder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._order22396)) as java.nio.ByteOrder;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly22397;
		public override bool isReadOnly()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.ShortBuffer_._isReadOnly22397);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.ShortBuffer_.staticClass, global::java.nio.ShortBuffer_._isReadOnly22397);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.ShortBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/ShortBuffer"));
			global::java.nio.ShortBuffer_._get22387 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "get", "()S");
			global::java.nio.ShortBuffer_._get22388 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "get", "(I)S");
			global::java.nio.ShortBuffer_._put22389 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "put", "(S)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer_._put22390 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "put", "(IS)Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer_._isDirect22391 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "isDirect", "()Z");
			global::java.nio.ShortBuffer_._duplicate22392 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "duplicate", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer_._slice22393 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "slice", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer_._asReadOnlyBuffer22394 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer_._compact22395 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "compact", "()Ljava/nio/ShortBuffer;");
			global::java.nio.ShortBuffer_._order22396 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "order", "()Ljava/nio/ByteOrder;");
			global::java.nio.ShortBuffer_._isReadOnly22397 = @__env.GetMethodIDNoThrow(global::java.nio.ShortBuffer_.staticClass, "isReadOnly", "()Z");
		}
	}
}
