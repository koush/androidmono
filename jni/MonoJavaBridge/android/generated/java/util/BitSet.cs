namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BitSet : java.lang.Object, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BitSet()
		{
			InitJNI();
		}
		protected BitSet(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get15247;
		public virtual global::java.util.BitSet get(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.BitSet._get15247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.BitSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._get15247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.BitSet;
		}
		internal static global::MonoJavaBridge.MethodId _get15248;
		public virtual bool get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.BitSet._get15248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._get15248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals15249;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.BitSet._equals15249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._equals15249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString15250;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.BitSet._toString15250)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._toString15250)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode15251;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.BitSet._hashCode15251);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._hashCode15251);
		}
		internal static global::MonoJavaBridge.MethodId _clone15252;
		public virtual new global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.BitSet._clone15252)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._clone15252)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear15253;
		public virtual void clear(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._clear15253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._clear15253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear15254;
		public virtual void clear(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._clear15254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._clear15254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear15255;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._clear15255);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._clear15255);
		}
		internal static global::MonoJavaBridge.MethodId _length15256;
		public virtual int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.BitSet._length15256);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._length15256);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty15257;
		public virtual bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.BitSet._isEmpty15257);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._isEmpty15257);
		}
		internal static global::MonoJavaBridge.MethodId _size15258;
		public virtual int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.BitSet._size15258);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._size15258);
		}
		internal static global::MonoJavaBridge.MethodId _set15259;
		public virtual void set(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._set15259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._set15259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _set15260;
		public virtual void set(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._set15260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._set15260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _set15261;
		public virtual void set(int arg0, int arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._set15261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._set15261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _set15262;
		public virtual void set(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._set15262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._set15262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flip15263;
		public virtual void flip(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._flip15263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._flip15263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flip15264;
		public virtual void flip(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._flip15264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._flip15264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _nextSetBit15265;
		public virtual int nextSetBit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.BitSet._nextSetBit15265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._nextSetBit15265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextClearBit15266;
		public virtual int nextClearBit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.BitSet._nextClearBit15266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._nextClearBit15266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _intersects15267;
		public virtual bool intersects(java.util.BitSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.BitSet._intersects15267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._intersects15267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cardinality15268;
		public virtual int cardinality() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.BitSet._cardinality15268);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._cardinality15268);
		}
		internal static global::MonoJavaBridge.MethodId _and15269;
		public virtual void and(java.util.BitSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._and15269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._and15269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _or15270;
		public virtual void or(java.util.BitSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._or15270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._or15270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _xor15271;
		public virtual void xor(java.util.BitSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._xor15271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._xor15271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _andNot15272;
		public virtual void andNot(java.util.BitSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._andNot15272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._andNot15272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BitSet15273;
		public BitSet()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.BitSet.staticClass, global::java.util.BitSet._BitSet15273);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BitSet15274;
		public BitSet(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.BitSet.staticClass, global::java.util.BitSet._BitSet15274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.BitSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/BitSet"));
			global::java.util.BitSet._get15247 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "get", "(II)Ljava/util/BitSet;");
			global::java.util.BitSet._get15248 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "get", "(I)Z");
			global::java.util.BitSet._equals15249 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.BitSet._toString15250 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.BitSet._hashCode15251 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "hashCode", "()I");
			global::java.util.BitSet._clone15252 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.BitSet._clear15253 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "clear", "(II)V");
			global::java.util.BitSet._clear15254 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "clear", "(I)V");
			global::java.util.BitSet._clear15255 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "clear", "()V");
			global::java.util.BitSet._length15256 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "length", "()I");
			global::java.util.BitSet._isEmpty15257 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "isEmpty", "()Z");
			global::java.util.BitSet._size15258 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "size", "()I");
			global::java.util.BitSet._set15259 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "set", "(IZ)V");
			global::java.util.BitSet._set15260 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "set", "(II)V");
			global::java.util.BitSet._set15261 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "set", "(IIZ)V");
			global::java.util.BitSet._set15262 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "set", "(I)V");
			global::java.util.BitSet._flip15263 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "flip", "(I)V");
			global::java.util.BitSet._flip15264 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "flip", "(II)V");
			global::java.util.BitSet._nextSetBit15265 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "nextSetBit", "(I)I");
			global::java.util.BitSet._nextClearBit15266 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "nextClearBit", "(I)I");
			global::java.util.BitSet._intersects15267 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "intersects", "(Ljava/util/BitSet;)Z");
			global::java.util.BitSet._cardinality15268 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "cardinality", "()I");
			global::java.util.BitSet._and15269 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "and", "(Ljava/util/BitSet;)V");
			global::java.util.BitSet._or15270 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "or", "(Ljava/util/BitSet;)V");
			global::java.util.BitSet._xor15271 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "xor", "(Ljava/util/BitSet;)V");
			global::java.util.BitSet._andNot15272 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "andNot", "(Ljava/util/BitSet;)V");
			global::java.util.BitSet._BitSet15273 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "<init>", "()V");
			global::java.util.BitSet._BitSet15274 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "<init>", "(I)V");
		}
	}
}
