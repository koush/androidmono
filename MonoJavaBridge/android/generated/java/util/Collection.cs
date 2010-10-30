namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.Collection_))]
	public partial interface Collection : java.lang.Iterable
	{
		bool add(java.lang.Object arg0);
		bool equals(java.lang.Object arg0);
		int hashCode();
		void clear();
		bool isEmpty();
		bool contains(java.lang.Object arg0);
		bool addAll(java.util.Collection arg0);
		int size();
		global::java.lang.Object[] toArray(java.lang.Object[] arg0);
		global::java.lang.Object[] toArray();
		global::java.util.Iterator iterator();
		bool remove(java.lang.Object arg0);
		bool containsAll(java.util.Collection arg0);
		bool removeAll(java.util.Collection arg0);
		bool retainAll(java.util.Collection arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.Collection))]
	internal sealed partial class Collection_ : java.lang.Object, Collection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Collection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add26006;
		bool java.util.Collection.add(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collection_._add26006.native == global::System.IntPtr.Zero)
				global::java.util.Collection_._add26006 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "add", "(Ljava/lang/Object;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Collection_._add26006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals26007;
		bool java.util.Collection.equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collection_._equals26007.native == global::System.IntPtr.Zero)
				global::java.util.Collection_._equals26007 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Collection_._equals26007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26008;
		int java.util.Collection.hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collection_._hashCode26008.native == global::System.IntPtr.Zero)
				global::java.util.Collection_._hashCode26008 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "hashCode", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.util.Collection_._hashCode26008);
		}
		internal static global::MonoJavaBridge.MethodId _clear26009;
		void java.util.Collection.clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collection_._clear26009.native == global::System.IntPtr.Zero)
				global::java.util.Collection_._clear26009 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "clear", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.util.Collection_._clear26009);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26010;
		bool java.util.Collection.isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collection_._isEmpty26010.native == global::System.IntPtr.Zero)
				global::java.util.Collection_._isEmpty26010 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "isEmpty", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Collection_._isEmpty26010);
		}
		internal static global::MonoJavaBridge.MethodId _contains26011;
		bool java.util.Collection.contains(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collection_._contains26011.native == global::System.IntPtr.Zero)
				global::java.util.Collection_._contains26011 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Collection_._contains26011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26012;
		bool java.util.Collection.addAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collection_._addAll26012.native == global::System.IntPtr.Zero)
				global::java.util.Collection_._addAll26012 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Collection_._addAll26012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size26013;
		int java.util.Collection.size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collection_._size26013.native == global::System.IntPtr.Zero)
				global::java.util.Collection_._size26013 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "size", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.util.Collection_._size26013);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26014;
		global::java.lang.Object[] java.util.Collection.toArray(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collection_._toArray26014.native == global::System.IntPtr.Zero)
				global::java.util.Collection_._toArray26014 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Collection_._toArray26014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26015;
		global::java.lang.Object[] java.util.Collection.toArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collection_._toArray26015.native == global::System.IntPtr.Zero)
				global::java.util.Collection_._toArray26015 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "toArray", "()[Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Collection_._toArray26015)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator26016;
		global::java.util.Iterator java.util.Collection.iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collection_._iterator26016.native == global::System.IntPtr.Zero)
				global::java.util.Collection_._iterator26016 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "iterator", "()Ljava/util/Iterator;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Collection_._iterator26016)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove26017;
		bool java.util.Collection.remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collection_._remove26017.native == global::System.IntPtr.Zero)
				global::java.util.Collection_._remove26017 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Collection_._remove26017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll26018;
		bool java.util.Collection.containsAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collection_._containsAll26018.native == global::System.IntPtr.Zero)
				global::java.util.Collection_._containsAll26018 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Collection_._containsAll26018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll26019;
		bool java.util.Collection.removeAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collection_._removeAll26019.native == global::System.IntPtr.Zero)
				global::java.util.Collection_._removeAll26019 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Collection_._removeAll26019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll26020;
		bool java.util.Collection.retainAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collection_._retainAll26020.native == global::System.IntPtr.Zero)
				global::java.util.Collection_._retainAll26020 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Collection_._retainAll26020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(((global::java.lang.Iterable)this).iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator26021;
		global::java.util.Iterator java.lang.Iterable.iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collection_._iterator26021.native == global::System.IntPtr.Zero)
				global::java.util.Collection_._iterator26021 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "iterator", "()Ljava/util/Iterator;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Collection_._iterator26021)) as java.util.Iterator;
		}
		static Collection_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Collection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Collection"));
		}
		internal static void InitJNI()
		{
		}
	}
}
