namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.Collection_))]
	public interface Collection : java.lang.Iterable
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
	public sealed partial class Collection_ : java.lang.Object, Collection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Collection_()
		{
			InitJNI();
		}
		internal Collection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add20067;
		 bool java.util.Collection.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Collection_._add20067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._add20067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals20068;
		 bool java.util.Collection.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Collection_._equals20068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._equals20068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20069;
		 int java.util.Collection.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Collection_._hashCode20069);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._hashCode20069);
		}
		internal static global::MonoJavaBridge.MethodId _clear20070;
		 void java.util.Collection.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Collection_._clear20070);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._clear20070);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty20071;
		 bool java.util.Collection.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Collection_._isEmpty20071);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._isEmpty20071);
		}
		internal static global::MonoJavaBridge.MethodId _contains20072;
		 bool java.util.Collection.contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Collection_._contains20072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._contains20072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll20073;
		 bool java.util.Collection.addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Collection_._addAll20073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._addAll20073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size20074;
		 int java.util.Collection.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Collection_._size20074);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._size20074);
		}
		internal static global::MonoJavaBridge.MethodId _toArray20075;
		 global::java.lang.Object[] java.util.Collection.toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Collection_._toArray20075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._toArray20075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray20076;
		 global::java.lang.Object[] java.util.Collection.toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Collection_._toArray20076)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._toArray20076)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator20077;
		 global::java.util.Iterator java.util.Collection.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Collection_._iterator20077)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._iterator20077)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove20078;
		 bool java.util.Collection.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Collection_._remove20078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._remove20078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll20079;
		 bool java.util.Collection.containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Collection_._containsAll20079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._containsAll20079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll20080;
		 bool java.util.Collection.removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Collection_._removeAll20080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._removeAll20080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll20081;
		 bool java.util.Collection.retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Collection_._retainAll20081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._retainAll20081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _iterator20082;
		 global::java.util.Iterator java.lang.Iterable.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Collection_._iterator20082)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._iterator20082)) as java.util.Iterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Collection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Collection"));
			global::java.util.Collection_._add20067 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.Collection_._equals20068 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Collection_._hashCode20069 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "hashCode", "()I");
			global::java.util.Collection_._clear20070 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "clear", "()V");
			global::java.util.Collection_._isEmpty20071 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "isEmpty", "()Z");
			global::java.util.Collection_._contains20072 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.Collection_._addAll20073 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.Collection_._size20074 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "size", "()I");
			global::java.util.Collection_._toArray20075 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.Collection_._toArray20076 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.Collection_._iterator20077 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.Collection_._remove20078 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.Collection_._containsAll20079 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.Collection_._removeAll20080 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.Collection_._retainAll20081 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.Collection_._iterator20082 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
	}
}
