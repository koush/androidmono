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
		internal static global::MonoJavaBridge.MethodId _get19981;
		public virtual global::java.util.BitSet get(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.BitSet._get19981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.BitSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._get19981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.BitSet;
		}
		internal static global::MonoJavaBridge.MethodId _get19982;
		public virtual bool get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.BitSet._get19982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._get19982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals19983;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.BitSet._equals19983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._equals19983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString19984;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.BitSet._toString19984)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._toString19984)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19985;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.BitSet._hashCode19985);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._hashCode19985);
		}
		internal static global::MonoJavaBridge.MethodId _clone19986;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.BitSet._clone19986)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._clone19986)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear19987;
		public virtual void clear(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._clear19987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._clear19987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear19988;
		public virtual void clear(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._clear19988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._clear19988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear19989;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._clear19989);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._clear19989);
		}
		internal static global::MonoJavaBridge.MethodId _length19990;
		public virtual int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.BitSet._length19990);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._length19990);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty19991;
		public virtual bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.BitSet._isEmpty19991);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._isEmpty19991);
		}
		internal static global::MonoJavaBridge.MethodId _size19992;
		public virtual int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.BitSet._size19992);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._size19992);
		}
		internal static global::MonoJavaBridge.MethodId _set19993;
		public virtual void set(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._set19993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._set19993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _set19994;
		public virtual void set(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._set19994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._set19994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _set19995;
		public virtual void set(int arg0, int arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._set19995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._set19995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _set19996;
		public virtual void set(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._set19996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._set19996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flip19997;
		public virtual void flip(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._flip19997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._flip19997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flip19998;
		public virtual void flip(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._flip19998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._flip19998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _nextSetBit19999;
		public virtual int nextSetBit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.BitSet._nextSetBit19999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._nextSetBit19999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextClearBit20000;
		public virtual int nextClearBit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.BitSet._nextClearBit20000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._nextClearBit20000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _intersects20001;
		public virtual bool intersects(java.util.BitSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.BitSet._intersects20001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._intersects20001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cardinality20002;
		public virtual int cardinality() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.BitSet._cardinality20002);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._cardinality20002);
		}
		internal static global::MonoJavaBridge.MethodId _and20003;
		public virtual void and(java.util.BitSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._and20003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._and20003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _or20004;
		public virtual void or(java.util.BitSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._or20004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._or20004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _xor20005;
		public virtual void xor(java.util.BitSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._xor20005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._xor20005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _andNot20006;
		public virtual void andNot(java.util.BitSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.BitSet._andNot20006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.BitSet.staticClass, global::java.util.BitSet._andNot20006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BitSet20007;
		public BitSet()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.BitSet.staticClass, global::java.util.BitSet._BitSet20007);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BitSet20008;
		public BitSet(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.BitSet.staticClass, global::java.util.BitSet._BitSet20008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.BitSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/BitSet"));
			global::java.util.BitSet._get19981 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "get", "(II)Ljava/util/BitSet;");
			global::java.util.BitSet._get19982 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "get", "(I)Z");
			global::java.util.BitSet._equals19983 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.BitSet._toString19984 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.BitSet._hashCode19985 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "hashCode", "()I");
			global::java.util.BitSet._clone19986 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.BitSet._clear19987 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "clear", "(II)V");
			global::java.util.BitSet._clear19988 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "clear", "(I)V");
			global::java.util.BitSet._clear19989 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "clear", "()V");
			global::java.util.BitSet._length19990 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "length", "()I");
			global::java.util.BitSet._isEmpty19991 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "isEmpty", "()Z");
			global::java.util.BitSet._size19992 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "size", "()I");
			global::java.util.BitSet._set19993 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "set", "(IZ)V");
			global::java.util.BitSet._set19994 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "set", "(II)V");
			global::java.util.BitSet._set19995 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "set", "(IIZ)V");
			global::java.util.BitSet._set19996 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "set", "(I)V");
			global::java.util.BitSet._flip19997 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "flip", "(I)V");
			global::java.util.BitSet._flip19998 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "flip", "(II)V");
			global::java.util.BitSet._nextSetBit19999 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "nextSetBit", "(I)I");
			global::java.util.BitSet._nextClearBit20000 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "nextClearBit", "(I)I");
			global::java.util.BitSet._intersects20001 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "intersects", "(Ljava/util/BitSet;)Z");
			global::java.util.BitSet._cardinality20002 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "cardinality", "()I");
			global::java.util.BitSet._and20003 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "and", "(Ljava/util/BitSet;)V");
			global::java.util.BitSet._or20004 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "or", "(Ljava/util/BitSet;)V");
			global::java.util.BitSet._xor20005 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "xor", "(Ljava/util/BitSet;)V");
			global::java.util.BitSet._andNot20006 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "andNot", "(Ljava/util/BitSet;)V");
			global::java.util.BitSet._BitSet20007 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "<init>", "()V");
			global::java.util.BitSet._BitSet20008 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "<init>", "(I)V");
		}
	}
}
