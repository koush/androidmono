namespace java.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class BitSet : java.lang.Object, java.lang.Cloneable, java.io.Serializable
	{ 
		internal static global::java.lang.Class staticClass; 
		static BitSet() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.util.BitSet), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.util.BitSet(@__env); 
			} 
		} 
		protected BitSet(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get12731; 
		public virtual java.util.BitSet get(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.BitSet>(@__env, @__env.CallObjectMethodPtr(this, _get12731, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.BitSet>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.BitSet.staticClass, _get12731, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get12732; 
		public virtual bool get(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				return @__env.CallBooleanMethod(this, _get12732, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.BitSet.staticClass, _get12732, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12733; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				return @__env.CallIntMethod(this, _hashCode12733); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.BitSet.staticClass, _hashCode12733); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clone12734; 
		public virtual java.lang.Object clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _clone12734)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.BitSet.staticClass, _clone12734)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals12735; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				return @__env.CallBooleanMethod(this, _equals12735, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.BitSet.staticClass, _equals12735, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear12736; 
		public virtual void clear(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				@__env.CallVoidMethod(this, _clear12736, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.BitSet.staticClass, _clear12736, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear12737; 
		public virtual void clear(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				@__env.CallVoidMethod(this, _clear12737, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.BitSet.staticClass, _clear12737, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear12738; 
		public virtual void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				@__env.CallVoidMethod(this, _clear12738); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.BitSet.staticClass, _clear12738); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString12739; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString12739)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.BitSet.staticClass, _toString12739)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _length12740; 
		public virtual int length() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				return @__env.CallIntMethod(this, _length12740); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.BitSet.staticClass, _length12740); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty12741; 
		public virtual bool isEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				return @__env.CallBooleanMethod(this, _isEmpty12741); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.BitSet.staticClass, _isEmpty12741); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _size12742; 
		public virtual int size() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				return @__env.CallIntMethod(this, _size12742); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.BitSet.staticClass, _size12742); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set12743; 
		public virtual void set(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				@__env.CallVoidMethod(this, _set12743, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.BitSet.staticClass, _set12743, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set12744; 
		public virtual void set(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				@__env.CallVoidMethod(this, _set12744, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.BitSet.staticClass, _set12744, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set12745; 
		public virtual void set(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				@__env.CallVoidMethod(this, _set12745, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.BitSet.staticClass, _set12745, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set12746; 
		public virtual void set(int arg0, int arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				@__env.CallVoidMethod(this, _set12746, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.BitSet.staticClass, _set12746, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _flip12747; 
		public virtual void flip(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				@__env.CallVoidMethod(this, _flip12747, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.BitSet.staticClass, _flip12747, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _flip12748; 
		public virtual void flip(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				@__env.CallVoidMethod(this, _flip12748, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.BitSet.staticClass, _flip12748, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextSetBit12749; 
		public virtual int nextSetBit(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				return @__env.CallIntMethod(this, _nextSetBit12749, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.BitSet.staticClass, _nextSetBit12749, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextClearBit12750; 
		public virtual int nextClearBit(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				return @__env.CallIntMethod(this, _nextClearBit12750, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.BitSet.staticClass, _nextClearBit12750, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _intersects12751; 
		public virtual bool intersects(java.util.BitSet arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				return @__env.CallBooleanMethod(this, _intersects12751, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.BitSet.staticClass, _intersects12751, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cardinality12752; 
		public virtual int cardinality() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				return @__env.CallIntMethod(this, _cardinality12752); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.BitSet.staticClass, _cardinality12752); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _and12753; 
		public virtual void and(java.util.BitSet arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				@__env.CallVoidMethod(this, _and12753, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.BitSet.staticClass, _and12753, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _or12754; 
		public virtual void or(java.util.BitSet arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				@__env.CallVoidMethod(this, _or12754, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.BitSet.staticClass, _or12754, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _xor12755; 
		public virtual void xor(java.util.BitSet arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				@__env.CallVoidMethod(this, _xor12755, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.BitSet.staticClass, _xor12755, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _andNot12756; 
		public virtual void andNot(java.util.BitSet arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.BitSet)) 
				@__env.CallVoidMethod(this, _andNot12756, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.BitSet.staticClass, _andNot12756, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BitSet12757; 
		public BitSet()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.BitSet.staticClass, _BitSet12757, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BitSet12758; 
		public BitSet(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.BitSet.staticClass, _BitSet12758, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.BitSet.staticClass = @__class; 
			global::java.util.BitSet._get12731 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "get", "(II)Ljava/util/BitSet;"); 
			global::java.util.BitSet._get12732 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "get", "(I)Z"); 
			global::java.util.BitSet._hashCode12733 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "hashCode", "()I"); 
			global::java.util.BitSet._clone12734 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "clone", "()Ljava/lang/Object;"); 
			global::java.util.BitSet._equals12735 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.util.BitSet._clear12736 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "clear", "(II)V"); 
			global::java.util.BitSet._clear12737 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "clear", "(I)V"); 
			global::java.util.BitSet._clear12738 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "clear", "()V"); 
			global::java.util.BitSet._toString12739 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.util.BitSet._length12740 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "length", "()I"); 
			global::java.util.BitSet._isEmpty12741 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "isEmpty", "()Z"); 
			global::java.util.BitSet._size12742 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "size", "()I"); 
			global::java.util.BitSet._set12743 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "set", "(IZ)V"); 
			global::java.util.BitSet._set12744 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "set", "(I)V"); 
			global::java.util.BitSet._set12745 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "set", "(II)V"); 
			global::java.util.BitSet._set12746 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "set", "(IIZ)V"); 
			global::java.util.BitSet._flip12747 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "flip", "(II)V"); 
			global::java.util.BitSet._flip12748 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "flip", "(I)V"); 
			global::java.util.BitSet._nextSetBit12749 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "nextSetBit", "(I)I"); 
			global::java.util.BitSet._nextClearBit12750 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "nextClearBit", "(I)I"); 
			global::java.util.BitSet._intersects12751 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "intersects", "(Ljava/util/BitSet;)Z"); 
			global::java.util.BitSet._cardinality12752 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "cardinality", "()I"); 
			global::java.util.BitSet._and12753 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "and", "(Ljava/util/BitSet;)V"); 
			global::java.util.BitSet._or12754 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "or", "(Ljava/util/BitSet;)V"); 
			global::java.util.BitSet._xor12755 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "xor", "(Ljava/util/BitSet;)V"); 
			global::java.util.BitSet._andNot12756 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "andNot", "(Ljava/util/BitSet;)V"); 
			global::java.util.BitSet._BitSet12757 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "<init>", "()V"); 
			global::java.util.BitSet._BitSet12758 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "<init>", "(I)V"); 
		} 
	} 
} 
