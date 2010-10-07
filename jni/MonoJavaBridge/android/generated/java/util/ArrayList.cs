namespace java.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ArrayList : java.util.AbstractList, List, RandomAccess, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::java.lang.Class staticClass;
		static ArrayList()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.util.ArrayList), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.util.ArrayList(@__env);
			}
		}
		protected ArrayList(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _add13536;
		public override void add(int arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.ArrayList._add13536, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._add13536, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _add13537;
		public override bool add(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.ArrayList._add13537, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._add13537, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _get13538;
		public override global::java.lang.Object get(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.ArrayList._get13538, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._get13538, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clone13539;
		public virtual new global::java.lang.Object clone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.ArrayList._clone13539));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._clone13539));
		}
		internal static global::net.sf.jni4net.jni.MethodId _indexOf13540;
		public override int indexOf(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.ArrayList._indexOf13540, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._indexOf13540, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear13541;
		public override void clear() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.ArrayList._clear13541);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._clear13541);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty13542;
		public override bool isEmpty() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.ArrayList._isEmpty13542);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._isEmpty13542);
		}
		internal static global::net.sf.jni4net.jni.MethodId _lastIndexOf13543;
		public override int lastIndexOf(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.ArrayList._lastIndexOf13543, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._lastIndexOf13543, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _contains13544;
		public override bool contains(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.ArrayList._contains13544, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._contains13544, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addAll13545;
		public override bool addAll(java.util.Collection arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.ArrayList._addAll13545, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._addAll13545, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addAll13546;
		public override bool addAll(int arg0, java.util.Collection arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.ArrayList._addAll13546, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._addAll13546, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _size13547;
		public override int size() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.ArrayList._size13547);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._size13547);
		}
		internal static global::net.sf.jni4net.jni.MethodId _toArray13548;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.util.ArrayList._toArray13548, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._toArray13548, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toArray13549;
		public override global::java.lang.Object[] toArray() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.util.ArrayList._toArray13549));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._toArray13549));
		}
		internal static global::net.sf.jni4net.jni.MethodId _remove13550;
		public override global::java.lang.Object remove(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.ArrayList._remove13550, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._remove13550, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _remove13551;
		public override bool remove(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.ArrayList._remove13551, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._remove13551, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _set13552;
		public override global::java.lang.Object set(int arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.ArrayList._set13552, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._set13552, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _trimToSize13553;
		public virtual void trimToSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.ArrayList._trimToSize13553);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._trimToSize13553);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ensureCapacity13554;
		public virtual void ensureCapacity(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.ArrayList._ensureCapacity13554, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._ensureCapacity13554, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeRange13555;
		protected override void removeRange(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.ArrayList._removeRange13555, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._removeRange13555, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ArrayList13556;
		public ArrayList(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.ArrayList.staticClass, global::java.util.ArrayList._ArrayList13556, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ArrayList13557;
		public ArrayList()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.ArrayList.staticClass, global::java.util.ArrayList._ArrayList13557, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ArrayList13558;
		public ArrayList(java.util.Collection arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.ArrayList.staticClass, global::java.util.ArrayList._ArrayList13558, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.util.ArrayList.staticClass = @__class;
			global::java.util.ArrayList._add13536 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "add", "(ILjava/lang/Object;)V");
			global::java.util.ArrayList._add13537 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.ArrayList._get13538 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "get", "(I)Ljava/lang/Object;");
			global::java.util.ArrayList._clone13539 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.ArrayList._indexOf13540 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "indexOf", "(Ljava/lang/Object;)I");
			global::java.util.ArrayList._clear13541 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "clear", "()V");
			global::java.util.ArrayList._isEmpty13542 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "isEmpty", "()Z");
			global::java.util.ArrayList._lastIndexOf13543 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I");
			global::java.util.ArrayList._contains13544 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.ArrayList._addAll13545 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.ArrayList._addAll13546 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "addAll", "(ILjava/util/Collection;)Z");
			global::java.util.ArrayList._size13547 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "size", "()I");
			global::java.util.ArrayList._toArray13548 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.ArrayList._toArray13549 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.ArrayList._remove13550 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "remove", "(I)Ljava/lang/Object;");
			global::java.util.ArrayList._remove13551 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.ArrayList._set13552 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;");
			global::java.util.ArrayList._trimToSize13553 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "trimToSize", "()V");
			global::java.util.ArrayList._ensureCapacity13554 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "ensureCapacity", "(I)V");
			global::java.util.ArrayList._removeRange13555 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "removeRange", "(II)V");
			global::java.util.ArrayList._ArrayList13556 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "<init>", "(I)V");
			global::java.util.ArrayList._ArrayList13557 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "<init>", "()V");
			global::java.util.ArrayList._ArrayList13558 = @__env.GetMethodID(global::java.util.ArrayList.staticClass, "<init>", "(Ljava/util/Collection;)V");
		}
	}
}
