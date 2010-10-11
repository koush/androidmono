namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.Set_))]
	public interface Set : Collection
	{
		new bool add(java.lang.Object arg0);
		new bool equals(java.lang.Object arg0);
		new int hashCode();
		new void clear();
		new bool isEmpty();
		new bool contains(java.lang.Object arg0);
		new bool addAll(java.util.Collection arg0);
		new int size();
		new global::java.lang.Object[] toArray();
		new global::java.lang.Object[] toArray(java.lang.Object[] arg0);
		new global::java.util.Iterator iterator();
		new bool remove(java.lang.Object arg0);
		new bool containsAll(java.util.Collection arg0);
		new bool removeAll(java.util.Collection arg0);
		new bool retainAll(java.util.Collection arg0);
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
		internal static global::MonoJavaBridge.MethodId _add15632;
		 bool java.util.Set.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._add15632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._add15632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals15633;
		 bool java.util.Set.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._equals15633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._equals15633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode15634;
		 int java.util.Set.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Set_._hashCode15634);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._hashCode15634);
		}
		internal static global::MonoJavaBridge.MethodId _clear15635;
		 void java.util.Set.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Set_._clear15635);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._clear15635);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty15636;
		 bool java.util.Set.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._isEmpty15636);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._isEmpty15636);
		}
		internal static global::MonoJavaBridge.MethodId _contains15637;
		 bool java.util.Set.contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._contains15637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._contains15637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll15638;
		 bool java.util.Set.addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._addAll15638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._addAll15638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size15639;
		 int java.util.Set.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Set_._size15639);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._size15639);
		}
		internal static global::MonoJavaBridge.MethodId _toArray15640;
		 global::java.lang.Object[] java.util.Set.toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._toArray15640)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._toArray15640)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray15641;
		 global::java.lang.Object[] java.util.Set.toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._toArray15641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._toArray15641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator15642;
		 global::java.util.Iterator java.util.Set.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._iterator15642)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._iterator15642)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove15643;
		 bool java.util.Set.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._remove15643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._remove15643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll15644;
		 bool java.util.Set.containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._containsAll15644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._containsAll15644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll15645;
		 bool java.util.Set.removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._removeAll15645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._removeAll15645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll15646;
		 bool java.util.Set.retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._retainAll15646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._retainAll15646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _add15647;
		 bool java.util.Collection.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._add15647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._add15647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals15648;
		 bool java.util.Collection.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._equals15648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._equals15648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode15649;
		 int java.util.Collection.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Set_._hashCode15649);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._hashCode15649);
		}
		internal static global::MonoJavaBridge.MethodId _clear15650;
		 void java.util.Collection.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Set_._clear15650);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._clear15650);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty15651;
		 bool java.util.Collection.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._isEmpty15651);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._isEmpty15651);
		}
		internal static global::MonoJavaBridge.MethodId _contains15652;
		 bool java.util.Collection.contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._contains15652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._contains15652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll15653;
		 bool java.util.Collection.addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._addAll15653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._addAll15653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size15654;
		 int java.util.Collection.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Set_._size15654);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._size15654);
		}
		internal static global::MonoJavaBridge.MethodId _toArray15655;
		 global::java.lang.Object[] java.util.Collection.toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._toArray15655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._toArray15655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray15656;
		 global::java.lang.Object[] java.util.Collection.toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._toArray15656)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._toArray15656)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator15657;
		 global::java.util.Iterator java.util.Collection.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._iterator15657)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._iterator15657)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove15658;
		 bool java.util.Collection.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._remove15658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._remove15658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll15659;
		 bool java.util.Collection.containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._containsAll15659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._containsAll15659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll15660;
		 bool java.util.Collection.removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._removeAll15660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._removeAll15660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll15661;
		 bool java.util.Collection.retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Set_._retainAll15661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._retainAll15661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _iterator15662;
		 global::java.util.Iterator java.lang.Iterable.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Set_._iterator15662)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Set_.staticClass, global::java.util.Set_._iterator15662)) as java.util.Iterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Set_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Set"));
			global::java.util.Set_._add15632 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._equals15633 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._hashCode15634 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "hashCode", "()I");
			global::java.util.Set_._clear15635 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "clear", "()V");
			global::java.util.Set_._isEmpty15636 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "isEmpty", "()Z");
			global::java.util.Set_._contains15637 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._addAll15638 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._size15639 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "size", "()I");
			global::java.util.Set_._toArray15640 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.Set_._toArray15641 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.Set_._iterator15642 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.Set_._remove15643 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._containsAll15644 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._removeAll15645 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._retainAll15646 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._add15647 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._equals15648 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._hashCode15649 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "hashCode", "()I");
			global::java.util.Set_._clear15650 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "clear", "()V");
			global::java.util.Set_._isEmpty15651 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "isEmpty", "()Z");
			global::java.util.Set_._contains15652 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._addAll15653 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._size15654 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "size", "()I");
			global::java.util.Set_._toArray15655 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.Set_._toArray15656 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.Set_._iterator15657 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.Set_._remove15658 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.Set_._containsAll15659 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._removeAll15660 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._retainAll15661 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.Set_._iterator15662 = @__env.GetMethodIDNoThrow(global::java.util.Set_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
	}
}
