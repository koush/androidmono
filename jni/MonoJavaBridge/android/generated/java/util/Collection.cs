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
		new global::java.util.Iterator iterator();
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
		internal static global::MonoJavaBridge.MethodId _add15333;
		 bool java.util.Collection.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Collection_._add15333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._add15333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals15334;
		 bool java.util.Collection.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Collection_._equals15334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._equals15334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode15335;
		 int java.util.Collection.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Collection_._hashCode15335);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._hashCode15335);
		}
		internal static global::MonoJavaBridge.MethodId _clear15336;
		 void java.util.Collection.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Collection_._clear15336);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._clear15336);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty15337;
		 bool java.util.Collection.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Collection_._isEmpty15337);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._isEmpty15337);
		}
		internal static global::MonoJavaBridge.MethodId _contains15338;
		 bool java.util.Collection.contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Collection_._contains15338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._contains15338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll15339;
		 bool java.util.Collection.addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Collection_._addAll15339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._addAll15339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size15340;
		 int java.util.Collection.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Collection_._size15340);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._size15340);
		}
		internal static global::MonoJavaBridge.MethodId _toArray15341;
		 global::java.lang.Object[] java.util.Collection.toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Collection_._toArray15341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._toArray15341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray15342;
		 global::java.lang.Object[] java.util.Collection.toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Collection_._toArray15342)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._toArray15342)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator15343;
		 global::java.util.Iterator java.util.Collection.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Collection_._iterator15343)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._iterator15343)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove15344;
		 bool java.util.Collection.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Collection_._remove15344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._remove15344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll15345;
		 bool java.util.Collection.containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Collection_._containsAll15345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._containsAll15345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll15346;
		 bool java.util.Collection.removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Collection_._removeAll15346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._removeAll15346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll15347;
		 bool java.util.Collection.retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Collection_._retainAll15347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._retainAll15347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _iterator15348;
		 global::java.util.Iterator java.lang.Iterable.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Collection_._iterator15348)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Collection_.staticClass, global::java.util.Collection_._iterator15348)) as java.util.Iterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Collection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Collection"));
			global::java.util.Collection_._add15333 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.Collection_._equals15334 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Collection_._hashCode15335 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "hashCode", "()I");
			global::java.util.Collection_._clear15336 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "clear", "()V");
			global::java.util.Collection_._isEmpty15337 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "isEmpty", "()Z");
			global::java.util.Collection_._contains15338 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.Collection_._addAll15339 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.Collection_._size15340 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "size", "()I");
			global::java.util.Collection_._toArray15341 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.Collection_._toArray15342 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.Collection_._iterator15343 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.Collection_._remove15344 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.Collection_._containsAll15345 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.Collection_._removeAll15346 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.Collection_._retainAll15347 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.Collection_._iterator15348 = @__env.GetMethodIDNoThrow(global::java.util.Collection_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
	}
}
