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
		internal static global::MonoJavaBridge.MethodId _get25875;
		public virtual global::java.util.BitSet get(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.BitSet._get25875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.BitSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._get25875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.BitSet;
		}
		internal static global::MonoJavaBridge.MethodId _get25876;
		public virtual bool get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.BitSet._get25876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._get25876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals25877;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.BitSet._equals25877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._equals25877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString25878;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.BitSet._toString25878)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._toString25878)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25879;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.BitSet._hashCode25879);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._hashCode25879);
		}
		internal static global::MonoJavaBridge.MethodId _clone25880;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.BitSet._clone25880)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._clone25880)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear25881;
		public virtual void clear(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._clear25881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._clear25881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear25882;
		public virtual void clear(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._clear25882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._clear25882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear25883;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._clear25883);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._clear25883);
		}
		internal static global::MonoJavaBridge.MethodId _length25884;
		public virtual int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.BitSet._length25884);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._length25884);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty25885;
		public virtual bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.BitSet._isEmpty25885);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._isEmpty25885);
		}
		internal static global::MonoJavaBridge.MethodId _size25886;
		public virtual int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.BitSet._size25886);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._size25886);
		}
		internal static global::MonoJavaBridge.MethodId _set25887;
		public virtual void set(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._set25887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._set25887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _set25888;
		public virtual void set(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._set25888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._set25888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _set25889;
		public virtual void set(int arg0, int arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._set25889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._set25889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _set25890;
		public virtual void set(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._set25890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._set25890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flip25891;
		public virtual void flip(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._flip25891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._flip25891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flip25892;
		public virtual void flip(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._flip25892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._flip25892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _nextSetBit25893;
		public virtual int nextSetBit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.BitSet._nextSetBit25893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._nextSetBit25893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextClearBit25894;
		public virtual int nextClearBit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.BitSet._nextClearBit25894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._nextClearBit25894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _intersects25895;
		public virtual bool intersects(java.util.BitSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.BitSet._intersects25895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._intersects25895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cardinality25896;
		public virtual int cardinality() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.BitSet._cardinality25896);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._cardinality25896);
		}
		internal static global::MonoJavaBridge.MethodId _and25897;
		public virtual void and(java.util.BitSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._and25897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._and25897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _or25898;
		public virtual void or(java.util.BitSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._or25898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._or25898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _xor25899;
		public virtual void xor(java.util.BitSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._xor25899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._xor25899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _andNot25900;
		public virtual void andNot(java.util.BitSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._andNot25900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._andNot25900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BitSet25901;
		public BitSet()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.BitSet.staticClass, global::java.util.BitSet._BitSet25901);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BitSet25902;
		public BitSet(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.BitSet.staticClass, global::java.util.BitSet._BitSet25902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.BitSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/BitSet"));
			global::java.util.BitSet._get25875 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "get", "(II)Ljava/util/BitSet;");
			global::java.util.BitSet._get25876 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "get", "(I)Z");
			global::java.util.BitSet._equals25877 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.BitSet._toString25878 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.BitSet._hashCode25879 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "hashCode", "()I");
			global::java.util.BitSet._clone25880 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.BitSet._clear25881 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "clear", "(II)V");
			global::java.util.BitSet._clear25882 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "clear", "(I)V");
			global::java.util.BitSet._clear25883 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "clear", "()V");
			global::java.util.BitSet._length25884 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "length", "()I");
			global::java.util.BitSet._isEmpty25885 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "isEmpty", "()Z");
			global::java.util.BitSet._size25886 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "size", "()I");
			global::java.util.BitSet._set25887 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "set", "(IZ)V");
			global::java.util.BitSet._set25888 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "set", "(II)V");
			global::java.util.BitSet._set25889 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "set", "(IIZ)V");
			global::java.util.BitSet._set25890 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "set", "(I)V");
			global::java.util.BitSet._flip25891 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "flip", "(I)V");
			global::java.util.BitSet._flip25892 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "flip", "(II)V");
			global::java.util.BitSet._nextSetBit25893 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "nextSetBit", "(I)I");
			global::java.util.BitSet._nextClearBit25894 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "nextClearBit", "(I)I");
			global::java.util.BitSet._intersects25895 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "intersects", "(Ljava/util/BitSet;)Z");
			global::java.util.BitSet._cardinality25896 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "cardinality", "()I");
			global::java.util.BitSet._and25897 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "and", "(Ljava/util/BitSet;)V");
			global::java.util.BitSet._or25898 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "or", "(Ljava/util/BitSet;)V");
			global::java.util.BitSet._xor25899 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "xor", "(Ljava/util/BitSet;)V");
			global::java.util.BitSet._andNot25900 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "andNot", "(Ljava/util/BitSet;)V");
			global::java.util.BitSet._BitSet25901 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "<init>", "()V");
			global::java.util.BitSet._BitSet25902 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "<init>", "(I)V");
		}
	}
}
