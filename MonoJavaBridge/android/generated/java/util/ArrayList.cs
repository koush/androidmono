namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ArrayList : java.util.AbstractList, List, RandomAccess, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ArrayList(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add25748;
		public override void add(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ArrayList._add25748.native == global::System.IntPtr.Zero)
				global::java.util.ArrayList._add25748 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "add", "(ILjava/lang/Object;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._add25748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _add25749;
		public override bool add(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ArrayList._add25749.native == global::System.IntPtr.Zero)
				global::java.util.ArrayList._add25749 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "add", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._add25749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _get25750;
		public override global::java.lang.Object get(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ArrayList._get25750.native == global::System.IntPtr.Zero)
				global::java.util.ArrayList._get25750 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "get", "(I)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._get25750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clone25751;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ArrayList._clone25751.native == global::System.IntPtr.Zero)
				global::java.util.ArrayList._clone25751 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "clone", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._clone25751) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _indexOf25752;
		public override int indexOf(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ArrayList._indexOf25752.native == global::System.IntPtr.Zero)
				global::java.util.ArrayList._indexOf25752 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "indexOf", "(Ljava/lang/Object;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._indexOf25752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear25753;
		public override void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ArrayList._clear25753.native == global::System.IntPtr.Zero)
				global::java.util.ArrayList._clear25753 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "clear", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._clear25753);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty25754;
		public override bool isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ArrayList._isEmpty25754.native == global::System.IntPtr.Zero)
				global::java.util.ArrayList._isEmpty25754 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "isEmpty", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._isEmpty25754);
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf25755;
		public override int lastIndexOf(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ArrayList._lastIndexOf25755.native == global::System.IntPtr.Zero)
				global::java.util.ArrayList._lastIndexOf25755 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._lastIndexOf25755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains25756;
		public override bool contains(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ArrayList._contains25756.native == global::System.IntPtr.Zero)
				global::java.util.ArrayList._contains25756 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "contains", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._contains25756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll25757;
		public override bool addAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ArrayList._addAll25757.native == global::System.IntPtr.Zero)
				global::java.util.ArrayList._addAll25757 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._addAll25757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll25758;
		public override bool addAll(int arg0, java.util.Collection arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ArrayList._addAll25758.native == global::System.IntPtr.Zero)
				global::java.util.ArrayList._addAll25758 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "addAll", "(ILjava/util/Collection;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._addAll25758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _size25759;
		public override int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ArrayList._size25759.native == global::System.IntPtr.Zero)
				global::java.util.ArrayList._size25759 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "size", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._size25759);
		}
		internal static global::MonoJavaBridge.MethodId _toArray25760;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ArrayList._toArray25760.native == global::System.IntPtr.Zero)
				global::java.util.ArrayList._toArray25760 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._toArray25760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray25761;
		public override global::java.lang.Object[] toArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ArrayList._toArray25761.native == global::System.IntPtr.Zero)
				global::java.util.ArrayList._toArray25761 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "toArray", "()[Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._toArray25761) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _remove25762;
		public override global::java.lang.Object remove(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ArrayList._remove25762.native == global::System.IntPtr.Zero)
				global::java.util.ArrayList._remove25762 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "remove", "(I)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._remove25762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove25763;
		public override bool remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ArrayList._remove25763.native == global::System.IntPtr.Zero)
				global::java.util.ArrayList._remove25763 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "remove", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._remove25763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set25764;
		public override global::java.lang.Object set(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ArrayList._set25764.native == global::System.IntPtr.Zero)
				global::java.util.ArrayList._set25764 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._set25764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _trimToSize25765;
		public virtual void trimToSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ArrayList._trimToSize25765.native == global::System.IntPtr.Zero)
				global::java.util.ArrayList._trimToSize25765 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "trimToSize", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._trimToSize25765);
		}
		internal static global::MonoJavaBridge.MethodId _ensureCapacity25766;
		public virtual void ensureCapacity(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ArrayList._ensureCapacity25766.native == global::System.IntPtr.Zero)
				global::java.util.ArrayList._ensureCapacity25766 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "ensureCapacity", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._ensureCapacity25766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeRange25767;
		protected override void removeRange(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ArrayList._removeRange25767.native == global::System.IntPtr.Zero)
				global::java.util.ArrayList._removeRange25767 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "removeRange", "(II)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.ArrayList.staticClass, global::java.util.ArrayList._removeRange25767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ArrayList25768;
		public ArrayList(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ArrayList._ArrayList25768.native == global::System.IntPtr.Zero)
				global::java.util.ArrayList._ArrayList25768 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.ArrayList.staticClass, global::java.util.ArrayList._ArrayList25768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ArrayList25769;
		public ArrayList() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ArrayList._ArrayList25769.native == global::System.IntPtr.Zero)
				global::java.util.ArrayList._ArrayList25769 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.ArrayList.staticClass, global::java.util.ArrayList._ArrayList25769);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ArrayList25770;
		public ArrayList(java.util.Collection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ArrayList._ArrayList25770.native == global::System.IntPtr.Zero)
				global::java.util.ArrayList._ArrayList25770 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.ArrayList.staticClass, global::java.util.ArrayList._ArrayList25770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ArrayList()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.ArrayList.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/ArrayList"));
		}
		internal static void InitJNI()
		{
		}
	}
}
