namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ArrayList : java.util.AbstractList, List, RandomAccess, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ArrayList()
		{
			InitJNI();
		}
		protected ArrayList(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add19853;
		public override void add(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.ArrayList._add19853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._add19853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _add19854;
		public override bool add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.ArrayList._add19854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._add19854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _get19855;
		public override global::java.lang.Object get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ArrayList._get19855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._get19855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clone19856;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ArrayList._clone19856)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._clone19856)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _indexOf19857;
		public override int indexOf(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.ArrayList._indexOf19857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._indexOf19857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear19858;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.ArrayList._clear19858);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._clear19858);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty19859;
		public override bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.ArrayList._isEmpty19859);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._isEmpty19859);
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf19860;
		public override int lastIndexOf(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.ArrayList._lastIndexOf19860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._lastIndexOf19860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains19861;
		public override bool contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.ArrayList._contains19861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._contains19861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll19862;
		public override bool addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.ArrayList._addAll19862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._addAll19862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll19863;
		public override bool addAll(int arg0, java.util.Collection arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.ArrayList._addAll19863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._addAll19863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _size19864;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.ArrayList._size19864);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._size19864);
		}
		internal static global::MonoJavaBridge.MethodId _toArray19865;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ArrayList._toArray19865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._toArray19865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray19866;
		public override global::java.lang.Object[] toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ArrayList._toArray19866)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._toArray19866)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _remove19867;
		public override global::java.lang.Object remove(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ArrayList._remove19867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._remove19867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove19868;
		public override bool remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.ArrayList._remove19868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._remove19868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set19869;
		public override global::java.lang.Object set(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ArrayList._set19869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._set19869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _trimToSize19870;
		public virtual void trimToSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.ArrayList._trimToSize19870);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._trimToSize19870);
		}
		internal static global::MonoJavaBridge.MethodId _ensureCapacity19871;
		public virtual void ensureCapacity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.ArrayList._ensureCapacity19871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._ensureCapacity19871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeRange19872;
		protected override void removeRange(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.ArrayList._removeRange19872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._removeRange19872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ArrayList19873;
		public ArrayList(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.ArrayList.staticClass, global::java.util.ArrayList._ArrayList19873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ArrayList19874;
		public ArrayList()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.ArrayList.staticClass, global::java.util.ArrayList._ArrayList19874);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ArrayList19875;
		public ArrayList(java.util.Collection arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.ArrayList.staticClass, global::java.util.ArrayList._ArrayList19875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.ArrayList.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/ArrayList"));
			global::java.util.ArrayList._add19853 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "add", "(ILjava/lang/Object;)V");
			global::java.util.ArrayList._add19854 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.ArrayList._get19855 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "get", "(I)Ljava/lang/Object;");
			global::java.util.ArrayList._clone19856 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.ArrayList._indexOf19857 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "indexOf", "(Ljava/lang/Object;)I");
			global::java.util.ArrayList._clear19858 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "clear", "()V");
			global::java.util.ArrayList._isEmpty19859 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "isEmpty", "()Z");
			global::java.util.ArrayList._lastIndexOf19860 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I");
			global::java.util.ArrayList._contains19861 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.ArrayList._addAll19862 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.ArrayList._addAll19863 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "addAll", "(ILjava/util/Collection;)Z");
			global::java.util.ArrayList._size19864 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "size", "()I");
			global::java.util.ArrayList._toArray19865 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.ArrayList._toArray19866 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.ArrayList._remove19867 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "remove", "(I)Ljava/lang/Object;");
			global::java.util.ArrayList._remove19868 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.ArrayList._set19869 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;");
			global::java.util.ArrayList._trimToSize19870 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "trimToSize", "()V");
			global::java.util.ArrayList._ensureCapacity19871 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "ensureCapacity", "(I)V");
			global::java.util.ArrayList._removeRange19872 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "removeRange", "(II)V");
			global::java.util.ArrayList._ArrayList19873 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "<init>", "(I)V");
			global::java.util.ArrayList._ArrayList19874 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "<init>", "()V");
			global::java.util.ArrayList._ArrayList19875 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "<init>", "(Ljava/util/Collection;)V");
		}
	}
}
