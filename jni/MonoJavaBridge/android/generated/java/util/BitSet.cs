namespace java.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class BitSet : java.lang.Object, java.lang.Cloneable, java.io.Serializable
	{
		internal static global::java.lang.Class staticClass;
		static BitSet()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.util.BitSet), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
		internal static global::net.sf.jni4net.jni.MethodId _get13559;
		public virtual global::java.util.BitSet get(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.BitSet>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.BitSet._get13559, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.BitSet>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._get13559, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _get13560;
		public virtual bool get(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.BitSet._get13560, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._get13560, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals13561;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.BitSet._equals13561, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._equals13561, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString13562;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.BitSet._toString13562));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._toString13562));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode13563;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.BitSet._hashCode13563);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._hashCode13563);
		}
		internal static global::net.sf.jni4net.jni.MethodId _clone13564;
		public virtual global::java.lang.Object clone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.BitSet._clone13564));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._clone13564));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear13565;
		public virtual void clear(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.BitSet._clear13565, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._clear13565, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear13566;
		public virtual void clear(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.BitSet._clear13566, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._clear13566, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear13567;
		public virtual void clear() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.BitSet._clear13567);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._clear13567);
		}
		internal static global::net.sf.jni4net.jni.MethodId _length13568;
		public virtual int length() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.BitSet._length13568);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._length13568);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty13569;
		public virtual bool isEmpty() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.BitSet._isEmpty13569);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._isEmpty13569);
		}
		internal static global::net.sf.jni4net.jni.MethodId _size13570;
		public virtual int size() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.BitSet._size13570);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._size13570);
		}
		internal static global::net.sf.jni4net.jni.MethodId _set13571;
		public virtual void set(int arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.BitSet._set13571, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._set13571, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _set13572;
		public virtual void set(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.BitSet._set13572, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._set13572, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _set13573;
		public virtual void set(int arg0, int arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.BitSet._set13573, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._set13573, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _set13574;
		public virtual void set(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.BitSet._set13574, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._set13574, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _flip13575;
		public virtual void flip(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.BitSet._flip13575, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._flip13575, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _flip13576;
		public virtual void flip(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.BitSet._flip13576, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._flip13576, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _nextSetBit13577;
		public virtual int nextSetBit(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.BitSet._nextSetBit13577, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._nextSetBit13577, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _nextClearBit13578;
		public virtual int nextClearBit(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.BitSet._nextClearBit13578, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._nextClearBit13578, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _intersects13579;
		public virtual bool intersects(java.util.BitSet arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.BitSet._intersects13579, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._intersects13579, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cardinality13580;
		public virtual int cardinality() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.BitSet._cardinality13580);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._cardinality13580);
		}
		internal static global::net.sf.jni4net.jni.MethodId _and13581;
		public virtual void and(java.util.BitSet arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.BitSet._and13581, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._and13581, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _or13582;
		public virtual void or(java.util.BitSet arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.BitSet._or13582, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._or13582, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _xor13583;
		public virtual void xor(java.util.BitSet arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.BitSet._xor13583, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._xor13583, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _andNot13584;
		public virtual void andNot(java.util.BitSet arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.BitSet._andNot13584, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.BitSet.staticClass, global::java.util.BitSet._andNot13584, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _BitSet13585;
		public BitSet()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.BitSet.staticClass, global::java.util.BitSet._BitSet13585, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _BitSet13586;
		public BitSet(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.BitSet.staticClass, global::java.util.BitSet._BitSet13586, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.util.BitSet.staticClass = @__class;
			global::java.util.BitSet._get13559 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "get", "(II)Ljava/util/BitSet;");
			global::java.util.BitSet._get13560 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "get", "(I)Z");
			global::java.util.BitSet._equals13561 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.BitSet._toString13562 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.BitSet._hashCode13563 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "hashCode", "()I");
			global::java.util.BitSet._clone13564 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.BitSet._clear13565 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "clear", "(II)V");
			global::java.util.BitSet._clear13566 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "clear", "(I)V");
			global::java.util.BitSet._clear13567 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "clear", "()V");
			global::java.util.BitSet._length13568 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "length", "()I");
			global::java.util.BitSet._isEmpty13569 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "isEmpty", "()Z");
			global::java.util.BitSet._size13570 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "size", "()I");
			global::java.util.BitSet._set13571 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "set", "(IZ)V");
			global::java.util.BitSet._set13572 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "set", "(II)V");
			global::java.util.BitSet._set13573 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "set", "(IIZ)V");
			global::java.util.BitSet._set13574 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "set", "(I)V");
			global::java.util.BitSet._flip13575 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "flip", "(I)V");
			global::java.util.BitSet._flip13576 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "flip", "(II)V");
			global::java.util.BitSet._nextSetBit13577 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "nextSetBit", "(I)I");
			global::java.util.BitSet._nextClearBit13578 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "nextClearBit", "(I)I");
			global::java.util.BitSet._intersects13579 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "intersects", "(Ljava/util/BitSet;)Z");
			global::java.util.BitSet._cardinality13580 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "cardinality", "()I");
			global::java.util.BitSet._and13581 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "and", "(Ljava/util/BitSet;)V");
			global::java.util.BitSet._or13582 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "or", "(Ljava/util/BitSet;)V");
			global::java.util.BitSet._xor13583 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "xor", "(Ljava/util/BitSet;)V");
			global::java.util.BitSet._andNot13584 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "andNot", "(Ljava/util/BitSet;)V");
			global::java.util.BitSet._BitSet13585 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "<init>", "()V");
			global::java.util.BitSet._BitSet13586 = @__env.GetMethodID(global::java.util.BitSet.staticClass, "<init>", "(I)V");
		}
	}
}
