namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.Set_))]
	public interface Set : Collection
	{
		bool add(java.lang.Object arg0);
		bool equals(java.lang.Object arg0);
		int hashCode();
		void clear();
		bool isEmpty();
		bool contains(java.lang.Object arg0);
		bool addAll(java.util.Collection arg0);
		int size();
		global::java.lang.Object[] toArray();
		global::java.lang.Object[] toArray(java.lang.Object[] arg0);
		global::java.util.Iterator iterator();
		bool remove(java.lang.Object arg0);
		bool containsAll(java.util.Collection arg0);
		bool removeAll(java.util.Collection arg0);
		bool retainAll(java.util.Collection arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.Set))]
	public sealed partial class Set_ : java.lang.Object, Set
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Set_()
		{
			InitJNI();
		}
		internal Set_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add20757;
		 bool java.util.Set.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._add20757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._add20757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals20758;
		 bool java.util.Set.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._equals20758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._equals20758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20759;
		 int java.util.Set.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Set_._hashCode20759);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._hashCode20759);
		}
		internal static global::MonoJavaBridge.MethodId _clear20760;
		 void java.util.Set.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Set_._clear20760);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._clear20760);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty20761;
		 bool java.util.Set.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._isEmpty20761);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._isEmpty20761);
		}
		internal static global::MonoJavaBridge.MethodId _contains20762;
		 bool java.util.Set.contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._contains20762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._contains20762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll20763;
		 bool java.util.Set.addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._addAll20763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._addAll20763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size20764;
		 int java.util.Set.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Set_._size20764);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._size20764);
		}
		internal static global::MonoJavaBridge.MethodId _toArray20765;
		 global::java.lang.Object[] java.util.Set.toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._toArray20765)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._toArray20765)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray20766;
		 global::java.lang.Object[] java.util.Set.toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._toArray20766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._toArray20766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator20767;
		 global::java.util.Iterator java.util.Set.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._iterator20767)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._iterator20767)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove20768;
		 bool java.util.Set.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._remove20768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._remove20768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll20769;
		 bool java.util.Set.containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._containsAll20769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._containsAll20769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll20770;
		 bool java.util.Set.removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._removeAll20770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._removeAll20770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll20771;
		 bool java.util.Set.retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._retainAll20771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._retainAll20771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _add20772;
		 bool java.util.Collection.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._add20772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._add20772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals20773;
		 bool java.util.Collection.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._equals20773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._equals20773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20774;
		 int java.util.Collection.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Set_._hashCode20774);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._hashCode20774);
		}
		internal static global::MonoJavaBridge.MethodId _clear20775;
		 void java.util.Collection.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Set_._clear20775);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._clear20775);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty20776;
		 bool java.util.Collection.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._isEmpty20776);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._isEmpty20776);
		}
		internal static global::MonoJavaBridge.MethodId _contains20777;
		 bool java.util.Collection.contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._contains20777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._contains20777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll20778;
		 bool java.util.Collection.addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._addAll20778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._addAll20778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size20779;
		 int java.util.Collection.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Set_._size20779);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._size20779);
		}
		internal static global::MonoJavaBridge.MethodId _toArray20780;
		 global::java.lang.Object[] java.util.Collection.toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._toArray20780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._toArray20780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray20781;
		 global::java.lang.Object[] java.util.Collection.toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._toArray20781)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._toArray20781)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator20782;
		 global::java.util.Iterator java.util.Collection.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._iterator20782)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._iterator20782)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove20783;
		 bool java.util.Collection.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._remove20783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._remove20783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll20784;
		 bool java.util.Collection.containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._containsAll20784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._containsAll20784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll20785;
		 bool java.util.Collection.removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._removeAll20785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._removeAll20785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll20786;
		 bool java.util.Collection.retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._retainAll20786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._retainAll20786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _iterator20787;
		 global::java.util.Iterator java.lang.Iterable.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._iterator20787)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._iterator20787)) as java.util.Iterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Set_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Set"));
			global::java.util.Set_._add20757 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._equals20758 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._hashCode20759 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "hashCode", "()I");
			global::java.util.Set_._clear20760 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "clear", "()V");
			global::java.util.Set_._isEmpty20761 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "isEmpty", "()Z");
			global::java.util.Set_._contains20762 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._addAll20763 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._size20764 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "size", "()I");
			global::java.util.Set_._toArray20765 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.Set_._toArray20766 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.Set_._iterator20767 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.Set_._remove20768 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._containsAll20769 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._removeAll20770 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._retainAll20771 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._add20772 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._equals20773 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._hashCode20774 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "hashCode", "()I");
			global::java.util.Set_._clear20775 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "clear", "()V");
			global::java.util.Set_._isEmpty20776 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "isEmpty", "()Z");
			global::java.util.Set_._contains20777 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._addAll20778 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._size20779 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "size", "()I");
			global::java.util.Set_._toArray20780 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.Set_._toArray20781 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.Set_._iterator20782 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.Set_._remove20783 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._containsAll20784 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._removeAll20785 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._retainAll20786 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._iterator20787 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
	}
}
