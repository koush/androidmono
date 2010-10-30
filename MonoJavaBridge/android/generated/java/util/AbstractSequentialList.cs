namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.AbstractSequentialList_))]
	public abstract partial class AbstractSequentialList : java.util.AbstractList
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractSequentialList(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add25732;
		public override void add(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.AbstractSequentialList.staticClass, global::java.util.AbstractSequentialList._add25732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _get25733;
		public override global::java.lang.Object get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.AbstractSequentialList.staticClass, global::java.util.AbstractSequentialList._get25733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _addAll25734;
		public override bool addAll(int arg0, java.util.Collection arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractSequentialList.staticClass, global::java.util.AbstractSequentialList._addAll25734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator25735;
		public override global::java.util.Iterator iterator()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.AbstractSequentialList.staticClass, global::java.util.AbstractSequentialList._iterator25735)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove25736;
		public override global::java.lang.Object remove(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.AbstractSequentialList.staticClass, global::java.util.AbstractSequentialList._remove25736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _set25737;
		public override global::java.lang.Object set(int arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.AbstractSequentialList.staticClass, global::java.util.AbstractSequentialList._set25737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _listIterator25738;
		public abstract global::java.util.ListIterator listIterator(int arg0);
		internal static global::MonoJavaBridge.MethodId _AbstractSequentialList25739;
		protected AbstractSequentialList() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.AbstractSequentialList.staticClass, global::java.util.AbstractSequentialList._AbstractSequentialList25739);
			Init(@__env, handle);
		}
		static AbstractSequentialList()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractSequentialList.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractSequentialList"));
			global::java.util.AbstractSequentialList._add25732 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSequentialList.staticClass, "add", "(ILjava/lang/Object;)V");
			global::java.util.AbstractSequentialList._get25733 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSequentialList.staticClass, "get", "(I)Ljava/lang/Object;");
			global::java.util.AbstractSequentialList._addAll25734 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSequentialList.staticClass, "addAll", "(ILjava/util/Collection;)Z");
			global::java.util.AbstractSequentialList._iterator25735 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSequentialList.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.AbstractSequentialList._remove25736 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSequentialList.staticClass, "remove", "(I)Ljava/lang/Object;");
			global::java.util.AbstractSequentialList._set25737 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSequentialList.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;");
			global::java.util.AbstractSequentialList._listIterator25738 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSequentialList.staticClass, "listIterator", "(I)Ljava/util/ListIterator;");
			global::java.util.AbstractSequentialList._AbstractSequentialList25739 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSequentialList.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.AbstractSequentialList))]
	internal sealed partial class AbstractSequentialList_ : java.util.AbstractSequentialList
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractSequentialList_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _listIterator25740;
		public override global::java.util.ListIterator listIterator(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractSequentialList_._listIterator25740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ListIterator;
		}
		internal static global::MonoJavaBridge.MethodId _size25741;
		public override int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.util.AbstractSequentialList_._size25741);
		}
		static AbstractSequentialList_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractSequentialList_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractSequentialList"));
			global::java.util.AbstractSequentialList_._listIterator25740 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSequentialList_.staticClass, "listIterator", "(I)Ljava/util/ListIterator;");
			global::java.util.AbstractSequentialList_._size25741 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSequentialList_.staticClass, "size", "()I");
		}
		internal static void InitJNI()
		{
		}
	}
}
