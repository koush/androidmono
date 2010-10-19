namespace android.provider
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class MediaStore : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MediaStore()
		{
			InitJNI();
		}
		internal MediaStore(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Audio : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Audio()
			{
				InitJNI();
			}
			internal Audio(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.MediaStore.Audio.AlbumColumns_))]
			public interface AlbumColumns  : global::MonoJavaBridge.IJavaObject 
			{
			}

			[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.MediaStore.Audio.AlbumColumns))]
			public sealed partial class AlbumColumns_ : java.lang.Object, AlbumColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static AlbumColumns_()
				{
					InitJNI();
				}
				internal AlbumColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Audio.AlbumColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Audio$AlbumColumns"));
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public static partial class AlbumColumnsConstants 
			{
				public static global::java.lang.String ALBUM_ID
				{
					get
					{
						return "album_id";
					}
				}
				public static global::java.lang.String ALBUM
				{
					get
					{
						return "album";
					}
				}
				public static global::java.lang.String ARTIST
				{
					get
					{
						return "artist";
					}
				}
				public static global::java.lang.String NUMBER_OF_SONGS
				{
					get
					{
						return "numsongs";
					}
				}
				public static global::java.lang.String NUMBER_OF_SONGS_FOR_ARTIST
				{
					get
					{
						return "numsongs_by_artist";
					}
				}
				public static global::java.lang.String FIRST_YEAR
				{
					get
					{
						return "minyear";
					}
				}
				public static global::java.lang.String LAST_YEAR
				{
					get
					{
						return "maxyear";
					}
				}
				public static global::java.lang.String ALBUM_KEY
				{
					get
					{
						return "album_key";
					}
				}
				public static global::java.lang.String ALBUM_ART
				{
					get
					{
						return "album_art";
					}
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class Albums : java.lang.Object, BaseColumns, AlbumColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static Albums()
				{
					InitJNI();
				}
				internal Albums(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				internal static global::MonoJavaBridge.MethodId _getContentUri7107;
				public static global::android.net.Uri getContentUri(java.lang.String arg0) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Audio.Albums.staticClass, global::android.provider.MediaStore.Audio.Albums._getContentUri7107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
				}
				internal static global::MonoJavaBridge.MethodId _Albums7108;
				public Albums()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.Audio.Albums.staticClass, global::android.provider.MediaStore.Audio.Albums._Albums7108);
					Init(@__env, handle);
				}
				internal static global::MonoJavaBridge.FieldId _INTERNAL_CONTENT_URI7109;
				public static global::android.net.Uri INTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				internal static global::MonoJavaBridge.FieldId _EXTERNAL_CONTENT_URI7110;
				public static global::android.net.Uri EXTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				public static global::java.lang.String CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.dir/albums";
					}
				}
				public static global::java.lang.String ENTRY_CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.item/album";
					}
				}
				public static global::java.lang.String DEFAULT_SORT_ORDER
				{
					get
					{
						return "album_key";
					}
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Audio.Albums.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Audio$Albums"));
					global::android.provider.MediaStore.Audio.Albums._getContentUri7107 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Audio.Albums.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;");
					global::android.provider.MediaStore.Audio.Albums._Albums7108 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.Audio.Albums.staticClass, "<init>", "()V");
				}
			}
			[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.MediaStore.Audio.ArtistColumns_))]
			public interface ArtistColumns  : global::MonoJavaBridge.IJavaObject 
			{
			}

			[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.MediaStore.Audio.ArtistColumns))]
			public sealed partial class ArtistColumns_ : java.lang.Object, ArtistColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static ArtistColumns_()
				{
					InitJNI();
				}
				internal ArtistColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Audio.ArtistColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Audio$ArtistColumns"));
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public static partial class ArtistColumnsConstants 
			{
				public static global::java.lang.String ARTIST
				{
					get
					{
						return "artist";
					}
				}
				public static global::java.lang.String ARTIST_KEY
				{
					get
					{
						return "artist_key";
					}
				}
				public static global::java.lang.String NUMBER_OF_ALBUMS
				{
					get
					{
						return "number_of_albums";
					}
				}
				public static global::java.lang.String NUMBER_OF_TRACKS
				{
					get
					{
						return "number_of_tracks";
					}
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class Artists : java.lang.Object, BaseColumns, ArtistColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static Artists()
				{
					InitJNI();
				}
				internal Artists(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				[global::MonoJavaBridge.JavaClass()]
				public sealed partial class Albums : java.lang.Object, AlbumColumns
				{
					internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
					static Albums()
					{
						InitJNI();
					}
					internal Albums(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
					{
					}
					internal static global::MonoJavaBridge.MethodId _getContentUri7111;
					public static global::android.net.Uri getContentUri(java.lang.String arg0, long arg1) 
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Audio.Artists.Albums.staticClass, global::android.provider.MediaStore.Audio.Artists.Albums._getContentUri7111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
					}
					internal static global::MonoJavaBridge.MethodId _Albums7112;
					public Albums()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.Audio.Artists.Albums.staticClass, global::android.provider.MediaStore.Audio.Artists.Albums._Albums7112);
						Init(@__env, handle);
					}
					private static void InitJNI()
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						global::android.provider.MediaStore.Audio.Artists.Albums.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Audio$Artists$Albums"));
						global::android.provider.MediaStore.Audio.Artists.Albums._getContentUri7111 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Audio.Artists.Albums.staticClass, "getContentUri", "(Ljava/lang/String;J)Landroid/net/Uri;");
						global::android.provider.MediaStore.Audio.Artists.Albums._Albums7112 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.Audio.Artists.Albums.staticClass, "<init>", "()V");
					}
				}
				internal static global::MonoJavaBridge.MethodId _getContentUri7113;
				public static global::android.net.Uri getContentUri(java.lang.String arg0) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Audio.Artists.staticClass, global::android.provider.MediaStore.Audio.Artists._getContentUri7113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
				}
				internal static global::MonoJavaBridge.MethodId _Artists7114;
				public Artists()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.Audio.Artists.staticClass, global::android.provider.MediaStore.Audio.Artists._Artists7114);
					Init(@__env, handle);
				}
				internal static global::MonoJavaBridge.FieldId _INTERNAL_CONTENT_URI7115;
				public static global::android.net.Uri INTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				internal static global::MonoJavaBridge.FieldId _EXTERNAL_CONTENT_URI7116;
				public static global::android.net.Uri EXTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				public static global::java.lang.String CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.dir/artists";
					}
				}
				public static global::java.lang.String ENTRY_CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.item/artist";
					}
				}
				public static global::java.lang.String DEFAULT_SORT_ORDER
				{
					get
					{
						return "artist_key";
					}
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Audio.Artists.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Audio$Artists"));
					global::android.provider.MediaStore.Audio.Artists._getContentUri7113 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Audio.Artists.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;");
					global::android.provider.MediaStore.Audio.Artists._Artists7114 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.Audio.Artists.staticClass, "<init>", "()V");
				}
			}
			[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.MediaStore.Audio.AudioColumns_))]
			public interface AudioColumns : MediaColumns
			{
			}

			[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.MediaStore.Audio.AudioColumns))]
			public sealed partial class AudioColumns_ : java.lang.Object, AudioColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static AudioColumns_()
				{
					InitJNI();
				}
				internal AudioColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Audio.AudioColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Audio$AudioColumns"));
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public static partial class AudioColumnsConstants 
			{
				public static global::java.lang.String TITLE_KEY
				{
					get
					{
						return "title_key";
					}
				}
				public static global::java.lang.String DURATION
				{
					get
					{
						return "duration";
					}
				}
				public static global::java.lang.String BOOKMARK
				{
					get
					{
						return "bookmark";
					}
				}
				public static global::java.lang.String ARTIST_ID
				{
					get
					{
						return "artist_id";
					}
				}
				public static global::java.lang.String ARTIST
				{
					get
					{
						return "artist";
					}
				}
				public static global::java.lang.String ARTIST_KEY
				{
					get
					{
						return "artist_key";
					}
				}
				public static global::java.lang.String COMPOSER
				{
					get
					{
						return "composer";
					}
				}
				public static global::java.lang.String ALBUM_ID
				{
					get
					{
						return "album_id";
					}
				}
				public static global::java.lang.String ALBUM
				{
					get
					{
						return "album";
					}
				}
				public static global::java.lang.String ALBUM_KEY
				{
					get
					{
						return "album_key";
					}
				}
				public static global::java.lang.String ALBUM_ART
				{
					get
					{
						return "album_art";
					}
				}
				public static global::java.lang.String TRACK
				{
					get
					{
						return "track";
					}
				}
				public static global::java.lang.String YEAR
				{
					get
					{
						return "year";
					}
				}
				public static global::java.lang.String IS_MUSIC
				{
					get
					{
						return "is_music";
					}
				}
				public static global::java.lang.String IS_PODCAST
				{
					get
					{
						return "is_podcast";
					}
				}
				public static global::java.lang.String IS_RINGTONE
				{
					get
					{
						return "is_ringtone";
					}
				}
				public static global::java.lang.String IS_ALARM
				{
					get
					{
						return "is_alarm";
					}
				}
				public static global::java.lang.String IS_NOTIFICATION
				{
					get
					{
						return "is_notification";
					}
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class Genres : java.lang.Object, BaseColumns, GenresColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static Genres()
				{
					InitJNI();
				}
				internal Genres(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				[global::MonoJavaBridge.JavaClass()]
				public sealed partial class Members : java.lang.Object, AudioColumns
				{
					internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
					static Members()
					{
						InitJNI();
					}
					internal Members(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
					{
					}
					internal static global::MonoJavaBridge.MethodId _getContentUri7117;
					public static global::android.net.Uri getContentUri(java.lang.String arg0, long arg1) 
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Audio.Genres.Members.staticClass, global::android.provider.MediaStore.Audio.Genres.Members._getContentUri7117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
					}
					internal static global::MonoJavaBridge.MethodId _Members7118;
					public Members()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.Audio.Genres.Members.staticClass, global::android.provider.MediaStore.Audio.Genres.Members._Members7118);
						Init(@__env, handle);
					}
					public static global::java.lang.String CONTENT_DIRECTORY
					{
						get
						{
							return "members";
						}
					}
					public static global::java.lang.String DEFAULT_SORT_ORDER
					{
						get
						{
							return "title_key";
						}
					}
					public static global::java.lang.String AUDIO_ID
					{
						get
						{
							return "audio_id";
						}
					}
					public static global::java.lang.String GENRE_ID
					{
						get
						{
							return "genre_id";
						}
					}
					private static void InitJNI()
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						global::android.provider.MediaStore.Audio.Genres.Members.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Audio$Genres$Members"));
						global::android.provider.MediaStore.Audio.Genres.Members._getContentUri7117 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Audio.Genres.Members.staticClass, "getContentUri", "(Ljava/lang/String;J)Landroid/net/Uri;");
						global::android.provider.MediaStore.Audio.Genres.Members._Members7118 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.Audio.Genres.Members.staticClass, "<init>", "()V");
					}
				}
				internal static global::MonoJavaBridge.MethodId _getContentUri7119;
				public static global::android.net.Uri getContentUri(java.lang.String arg0) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Audio.Genres.staticClass, global::android.provider.MediaStore.Audio.Genres._getContentUri7119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
				}
				internal static global::MonoJavaBridge.MethodId _Genres7120;
				public Genres()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.Audio.Genres.staticClass, global::android.provider.MediaStore.Audio.Genres._Genres7120);
					Init(@__env, handle);
				}
				internal static global::MonoJavaBridge.FieldId _INTERNAL_CONTENT_URI7121;
				public static global::android.net.Uri INTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				internal static global::MonoJavaBridge.FieldId _EXTERNAL_CONTENT_URI7122;
				public static global::android.net.Uri EXTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				public static global::java.lang.String CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.dir/genre";
					}
				}
				public static global::java.lang.String ENTRY_CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.item/genre";
					}
				}
				public static global::java.lang.String DEFAULT_SORT_ORDER
				{
					get
					{
						return "name";
					}
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Audio.Genres.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Audio$Genres"));
					global::android.provider.MediaStore.Audio.Genres._getContentUri7119 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Audio.Genres.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;");
					global::android.provider.MediaStore.Audio.Genres._Genres7120 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.Audio.Genres.staticClass, "<init>", "()V");
				}
			}
			[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.MediaStore.Audio.GenresColumns_))]
			public interface GenresColumns  : global::MonoJavaBridge.IJavaObject 
			{
			}

			[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.MediaStore.Audio.GenresColumns))]
			public sealed partial class GenresColumns_ : java.lang.Object, GenresColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static GenresColumns_()
				{
					InitJNI();
				}
				internal GenresColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Audio.GenresColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Audio$GenresColumns"));
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public static partial class GenresColumnsConstants 
			{
				public static global::java.lang.String NAME
				{
					get
					{
						return "name";
					}
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class Media : java.lang.Object, AudioColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static Media()
				{
					InitJNI();
				}
				internal Media(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				internal static global::MonoJavaBridge.MethodId _getContentUri7123;
				public static global::android.net.Uri getContentUri(java.lang.String arg0) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Audio.Media.staticClass, global::android.provider.MediaStore.Audio.Media._getContentUri7123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
				}
				internal static global::MonoJavaBridge.MethodId _getContentUriForPath7124;
				public static global::android.net.Uri getContentUriForPath(java.lang.String arg0) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Audio.Media.staticClass, global::android.provider.MediaStore.Audio.Media._getContentUriForPath7124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
				}
				internal static global::MonoJavaBridge.MethodId _Media7125;
				public Media()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.Audio.Media.staticClass, global::android.provider.MediaStore.Audio.Media._Media7125);
					Init(@__env, handle);
				}
				internal static global::MonoJavaBridge.FieldId _INTERNAL_CONTENT_URI7126;
				public static global::android.net.Uri INTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				internal static global::MonoJavaBridge.FieldId _EXTERNAL_CONTENT_URI7127;
				public static global::android.net.Uri EXTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				public static global::java.lang.String CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.dir/audio";
					}
				}
				public static global::java.lang.String DEFAULT_SORT_ORDER
				{
					get
					{
						return "title_key";
					}
				}
				public static global::java.lang.String RECORD_SOUND_ACTION
				{
					get
					{
						return "android.provider.MediaStore.RECORD_SOUND";
					}
				}
				public static global::java.lang.String EXTRA_MAX_BYTES
				{
					get
					{
						return "android.provider.MediaStore.extra.MAX_BYTES";
					}
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Audio.Media.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Audio$Media"));
					global::android.provider.MediaStore.Audio.Media._getContentUri7123 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Audio.Media.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;");
					global::android.provider.MediaStore.Audio.Media._getContentUriForPath7124 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Audio.Media.staticClass, "getContentUriForPath", "(Ljava/lang/String;)Landroid/net/Uri;");
					global::android.provider.MediaStore.Audio.Media._Media7125 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.Audio.Media.staticClass, "<init>", "()V");
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class Playlists : java.lang.Object, BaseColumns, PlaylistsColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static Playlists()
				{
					InitJNI();
				}
				internal Playlists(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				[global::MonoJavaBridge.JavaClass()]
				public sealed partial class Members : java.lang.Object, AudioColumns
				{
					internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
					static Members()
					{
						InitJNI();
					}
					internal Members(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
					{
					}
					internal static global::MonoJavaBridge.MethodId _getContentUri7128;
					public static global::android.net.Uri getContentUri(java.lang.String arg0, long arg1) 
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Audio.Playlists.Members.staticClass, global::android.provider.MediaStore.Audio.Playlists.Members._getContentUri7128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
					}
					internal static global::MonoJavaBridge.MethodId _moveItem7129;
					public static bool moveItem(android.content.ContentResolver arg0, long arg1, int arg2, int arg3) 
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						return @__env.CallStaticBooleanMethod(android.provider.MediaStore.Audio.Playlists.Members.staticClass, global::android.provider.MediaStore.Audio.Playlists.Members._moveItem7129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
					}
					internal static global::MonoJavaBridge.MethodId _Members7130;
					public Members()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.Audio.Playlists.Members.staticClass, global::android.provider.MediaStore.Audio.Playlists.Members._Members7130);
						Init(@__env, handle);
					}
					public static global::java.lang.String _ID
					{
						get
						{
							return "_id";
						}
					}
					public static global::java.lang.String CONTENT_DIRECTORY
					{
						get
						{
							return "members";
						}
					}
					public static global::java.lang.String AUDIO_ID
					{
						get
						{
							return "audio_id";
						}
					}
					public static global::java.lang.String PLAYLIST_ID
					{
						get
						{
							return "playlist_id";
						}
					}
					public static global::java.lang.String PLAY_ORDER
					{
						get
						{
							return "play_order";
						}
					}
					public static global::java.lang.String DEFAULT_SORT_ORDER
					{
						get
						{
							return "play_order";
						}
					}
					private static void InitJNI()
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						global::android.provider.MediaStore.Audio.Playlists.Members.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Audio$Playlists$Members"));
						global::android.provider.MediaStore.Audio.Playlists.Members._getContentUri7128 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Audio.Playlists.Members.staticClass, "getContentUri", "(Ljava/lang/String;J)Landroid/net/Uri;");
						global::android.provider.MediaStore.Audio.Playlists.Members._moveItem7129 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Audio.Playlists.Members.staticClass, "moveItem", "(Landroid/content/ContentResolver;JII)Z");
						global::android.provider.MediaStore.Audio.Playlists.Members._Members7130 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.Audio.Playlists.Members.staticClass, "<init>", "()V");
					}
				}
				internal static global::MonoJavaBridge.MethodId _getContentUri7131;
				public static global::android.net.Uri getContentUri(java.lang.String arg0) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Audio.Playlists.staticClass, global::android.provider.MediaStore.Audio.Playlists._getContentUri7131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
				}
				internal static global::MonoJavaBridge.MethodId _Playlists7132;
				public Playlists()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.Audio.Playlists.staticClass, global::android.provider.MediaStore.Audio.Playlists._Playlists7132);
					Init(@__env, handle);
				}
				internal static global::MonoJavaBridge.FieldId _INTERNAL_CONTENT_URI7133;
				public static global::android.net.Uri INTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				internal static global::MonoJavaBridge.FieldId _EXTERNAL_CONTENT_URI7134;
				public static global::android.net.Uri EXTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				public static global::java.lang.String CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.dir/playlist";
					}
				}
				public static global::java.lang.String ENTRY_CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.item/playlist";
					}
				}
				public static global::java.lang.String DEFAULT_SORT_ORDER
				{
					get
					{
						return "name";
					}
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Audio.Playlists.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Audio$Playlists"));
					global::android.provider.MediaStore.Audio.Playlists._getContentUri7131 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Audio.Playlists.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;");
					global::android.provider.MediaStore.Audio.Playlists._Playlists7132 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.Audio.Playlists.staticClass, "<init>", "()V");
				}
			}
			[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.MediaStore.Audio.PlaylistsColumns_))]
			public interface PlaylistsColumns  : global::MonoJavaBridge.IJavaObject 
			{
			}

			[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.MediaStore.Audio.PlaylistsColumns))]
			public sealed partial class PlaylistsColumns_ : java.lang.Object, PlaylistsColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static PlaylistsColumns_()
				{
					InitJNI();
				}
				internal PlaylistsColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Audio.PlaylistsColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Audio$PlaylistsColumns"));
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public static partial class PlaylistsColumnsConstants 
			{
				public static global::java.lang.String NAME
				{
					get
					{
						return "name";
					}
				}
				public static global::java.lang.String DATA
				{
					get
					{
						return "_data";
					}
				}
				public static global::java.lang.String DATE_ADDED
				{
					get
					{
						return "date_added";
					}
				}
				public static global::java.lang.String DATE_MODIFIED
				{
					get
					{
						return "date_modified";
					}
				}
			}
			internal static global::MonoJavaBridge.MethodId _keyFor7135;
			public static global::java.lang.String keyFor(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Audio.staticClass, global::android.provider.MediaStore.Audio._keyFor7135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _Audio7136;
			public Audio()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.Audio.staticClass, global::android.provider.MediaStore.Audio._Audio7136);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.MediaStore.Audio.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Audio"));
				global::android.provider.MediaStore.Audio._keyFor7135 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Audio.staticClass, "keyFor", "(Ljava/lang/String;)Ljava/lang/String;");
				global::android.provider.MediaStore.Audio._Audio7136 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.Audio.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Images : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Images()
			{
				InitJNI();
			}
			internal Images(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.MediaStore.Images.ImageColumns_))]
			public interface ImageColumns : MediaColumns
			{
			}

			[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.MediaStore.Images.ImageColumns))]
			public sealed partial class ImageColumns_ : java.lang.Object, ImageColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static ImageColumns_()
				{
					InitJNI();
				}
				internal ImageColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Images.ImageColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Images$ImageColumns"));
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public static partial class ImageColumnsConstants 
			{
				public static global::java.lang.String DESCRIPTION
				{
					get
					{
						return "description";
					}
				}
				public static global::java.lang.String PICASA_ID
				{
					get
					{
						return "picasa_id";
					}
				}
				public static global::java.lang.String IS_PRIVATE
				{
					get
					{
						return "isprivate";
					}
				}
				public static global::java.lang.String LATITUDE
				{
					get
					{
						return "latitude";
					}
				}
				public static global::java.lang.String LONGITUDE
				{
					get
					{
						return "longitude";
					}
				}
				public static global::java.lang.String DATE_TAKEN
				{
					get
					{
						return "datetaken";
					}
				}
				public static global::java.lang.String ORIENTATION
				{
					get
					{
						return "orientation";
					}
				}
				public static global::java.lang.String MINI_THUMB_MAGIC
				{
					get
					{
						return "mini_thumb_magic";
					}
				}
				public static global::java.lang.String BUCKET_ID
				{
					get
					{
						return "bucket_id";
					}
				}
				public static global::java.lang.String BUCKET_DISPLAY_NAME
				{
					get
					{
						return "bucket_display_name";
					}
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class Media : java.lang.Object, ImageColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static Media()
				{
					InitJNI();
				}
				internal Media(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				internal static global::MonoJavaBridge.MethodId _query7137;
				public static global::android.database.Cursor query(android.content.ContentResolver arg0, android.net.Uri arg1, java.lang.String[] arg2) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallStaticObjectMethod(android.provider.MediaStore.Images.Media.staticClass, global::android.provider.MediaStore.Images.Media._query7137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.database.Cursor;
				}
				internal static global::MonoJavaBridge.MethodId _query7138;
				public static global::android.database.Cursor query(android.content.ContentResolver arg0, android.net.Uri arg1, java.lang.String[] arg2, java.lang.String arg3, java.lang.String arg4) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallStaticObjectMethod(android.provider.MediaStore.Images.Media.staticClass, global::android.provider.MediaStore.Images.Media._query7138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.database.Cursor;
				}
				internal static global::MonoJavaBridge.MethodId _query7139;
				public static global::android.database.Cursor query(android.content.ContentResolver arg0, android.net.Uri arg1, java.lang.String[] arg2, java.lang.String arg3, java.lang.String[] arg4, java.lang.String arg5) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallStaticObjectMethod(android.provider.MediaStore.Images.Media.staticClass, global::android.provider.MediaStore.Images.Media._query7139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as android.database.Cursor;
				}
				internal static global::MonoJavaBridge.MethodId _getBitmap7140;
				public static global::android.graphics.Bitmap getBitmap(android.content.ContentResolver arg0, android.net.Uri arg1) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Images.Media.staticClass, global::android.provider.MediaStore.Images.Media._getBitmap7140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Bitmap;
				}
				internal static global::MonoJavaBridge.MethodId _getContentUri7141;
				public static global::android.net.Uri getContentUri(java.lang.String arg0) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Images.Media.staticClass, global::android.provider.MediaStore.Images.Media._getContentUri7141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
				}
				internal static global::MonoJavaBridge.MethodId _insertImage7142;
				public static global::java.lang.String insertImage(android.content.ContentResolver arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Images.Media.staticClass, global::android.provider.MediaStore.Images.Media._insertImage7142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.String;
				}
				internal static global::MonoJavaBridge.MethodId _insertImage7143;
				public static global::java.lang.String insertImage(android.content.ContentResolver arg0, android.graphics.Bitmap arg1, java.lang.String arg2, java.lang.String arg3) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Images.Media.staticClass, global::android.provider.MediaStore.Images.Media._insertImage7143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.String;
				}
				internal static global::MonoJavaBridge.MethodId _Media7144;
				public Media()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.Images.Media.staticClass, global::android.provider.MediaStore.Images.Media._Media7144);
					Init(@__env, handle);
				}
				internal static global::MonoJavaBridge.FieldId _INTERNAL_CONTENT_URI7145;
				public static global::android.net.Uri INTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				internal static global::MonoJavaBridge.FieldId _EXTERNAL_CONTENT_URI7146;
				public static global::android.net.Uri EXTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				public static global::java.lang.String CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.dir/image";
					}
				}
				public static global::java.lang.String DEFAULT_SORT_ORDER
				{
					get
					{
						return "bucket_display_name";
					}
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Images.Media.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Images$Media"));
					global::android.provider.MediaStore.Images.Media._query7137 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Images.Media.staticClass, "query", "(Landroid/content/ContentResolver;Landroid/net/Uri;[Ljava/lang/String;)Landroid/database/Cursor;");
					global::android.provider.MediaStore.Images.Media._query7138 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Images.Media.staticClass, "query", "(Landroid/content/ContentResolver;Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
					global::android.provider.MediaStore.Images.Media._query7139 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Images.Media.staticClass, "query", "(Landroid/content/ContentResolver;Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
					global::android.provider.MediaStore.Images.Media._getBitmap7140 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Images.Media.staticClass, "getBitmap", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Landroid/graphics/Bitmap;");
					global::android.provider.MediaStore.Images.Media._getContentUri7141 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Images.Media.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;");
					global::android.provider.MediaStore.Images.Media._insertImage7142 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Images.Media.staticClass, "insertImage", "(Landroid/content/ContentResolver;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
					global::android.provider.MediaStore.Images.Media._insertImage7143 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Images.Media.staticClass, "insertImage", "(Landroid/content/ContentResolver;Landroid/graphics/Bitmap;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
					global::android.provider.MediaStore.Images.Media._Media7144 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.Images.Media.staticClass, "<init>", "()V");
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public partial class Thumbnails : java.lang.Object, BaseColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static Thumbnails()
				{
					InitJNI();
				}
				protected Thumbnails(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				internal static global::MonoJavaBridge.MethodId _query7147;
				public static global::android.database.Cursor query(android.content.ContentResolver arg0, android.net.Uri arg1, java.lang.String[] arg2) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallStaticObjectMethod(android.provider.MediaStore.Images.Thumbnails.staticClass, global::android.provider.MediaStore.Images.Thumbnails._query7147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.database.Cursor;
				}
				internal static global::MonoJavaBridge.MethodId _getThumbnail7148;
				public static global::android.graphics.Bitmap getThumbnail(android.content.ContentResolver arg0, long arg1, long arg2, int arg3, android.graphics.BitmapFactory.Options arg4) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Images.Thumbnails.staticClass, global::android.provider.MediaStore.Images.Thumbnails._getThumbnail7148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.graphics.Bitmap;
				}
				internal static global::MonoJavaBridge.MethodId _getThumbnail7149;
				public static global::android.graphics.Bitmap getThumbnail(android.content.ContentResolver arg0, long arg1, int arg2, android.graphics.BitmapFactory.Options arg3) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Images.Thumbnails.staticClass, global::android.provider.MediaStore.Images.Thumbnails._getThumbnail7149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.Bitmap;
				}
				internal static global::MonoJavaBridge.MethodId _getContentUri7150;
				public static global::android.net.Uri getContentUri(java.lang.String arg0) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Images.Thumbnails.staticClass, global::android.provider.MediaStore.Images.Thumbnails._getContentUri7150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
				}
				internal static global::MonoJavaBridge.MethodId _queryMiniThumbnails7151;
				public static global::android.database.Cursor queryMiniThumbnails(android.content.ContentResolver arg0, android.net.Uri arg1, int arg2, java.lang.String[] arg3) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallStaticObjectMethod(android.provider.MediaStore.Images.Thumbnails.staticClass, global::android.provider.MediaStore.Images.Thumbnails._queryMiniThumbnails7151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.database.Cursor;
				}
				internal static global::MonoJavaBridge.MethodId _queryMiniThumbnail7152;
				public static global::android.database.Cursor queryMiniThumbnail(android.content.ContentResolver arg0, long arg1, int arg2, java.lang.String[] arg3) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallStaticObjectMethod(android.provider.MediaStore.Images.Thumbnails.staticClass, global::android.provider.MediaStore.Images.Thumbnails._queryMiniThumbnail7152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.database.Cursor;
				}
				internal static global::MonoJavaBridge.MethodId _cancelThumbnailRequest7153;
				public static void cancelThumbnailRequest(android.content.ContentResolver arg0, long arg1, long arg2) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					@__env.CallStaticVoidMethod(android.provider.MediaStore.Images.Thumbnails.staticClass, global::android.provider.MediaStore.Images.Thumbnails._cancelThumbnailRequest7153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				}
				internal static global::MonoJavaBridge.MethodId _cancelThumbnailRequest7154;
				public static void cancelThumbnailRequest(android.content.ContentResolver arg0, long arg1) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					@__env.CallStaticVoidMethod(android.provider.MediaStore.Images.Thumbnails.staticClass, global::android.provider.MediaStore.Images.Thumbnails._cancelThumbnailRequest7154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				}
				internal static global::MonoJavaBridge.MethodId _Thumbnails7155;
				public Thumbnails()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.Images.Thumbnails.staticClass, global::android.provider.MediaStore.Images.Thumbnails._Thumbnails7155);
					Init(@__env, handle);
				}
				internal static global::MonoJavaBridge.FieldId _INTERNAL_CONTENT_URI7156;
				public static global::android.net.Uri INTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				internal static global::MonoJavaBridge.FieldId _EXTERNAL_CONTENT_URI7157;
				public static global::android.net.Uri EXTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				public static global::java.lang.String DEFAULT_SORT_ORDER
				{
					get
					{
						return "image_id ASC";
					}
				}
				public static global::java.lang.String DATA
				{
					get
					{
						return "_data";
					}
				}
				public static global::java.lang.String IMAGE_ID
				{
					get
					{
						return "image_id";
					}
				}
				public static global::java.lang.String KIND
				{
					get
					{
						return "kind";
					}
				}
				public static int MINI_KIND
				{
					get
					{
						return 1;
					}
				}
				public static int FULL_SCREEN_KIND
				{
					get
					{
						return 2;
					}
				}
				public static int MICRO_KIND
				{
					get
					{
						return 3;
					}
				}
				public static global::java.lang.String THUMB_DATA
				{
					get
					{
						return "thumb_data";
					}
				}
				public static global::java.lang.String WIDTH
				{
					get
					{
						return "width";
					}
				}
				public static global::java.lang.String HEIGHT
				{
					get
					{
						return "height";
					}
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Images.Thumbnails.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Images$Thumbnails"));
					global::android.provider.MediaStore.Images.Thumbnails._query7147 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "query", "(Landroid/content/ContentResolver;Landroid/net/Uri;[Ljava/lang/String;)Landroid/database/Cursor;");
					global::android.provider.MediaStore.Images.Thumbnails._getThumbnail7148 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "getThumbnail", "(Landroid/content/ContentResolver;JJILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
					global::android.provider.MediaStore.Images.Thumbnails._getThumbnail7149 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "getThumbnail", "(Landroid/content/ContentResolver;JILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
					global::android.provider.MediaStore.Images.Thumbnails._getContentUri7150 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;");
					global::android.provider.MediaStore.Images.Thumbnails._queryMiniThumbnails7151 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "queryMiniThumbnails", "(Landroid/content/ContentResolver;Landroid/net/Uri;I[Ljava/lang/String;)Landroid/database/Cursor;");
					global::android.provider.MediaStore.Images.Thumbnails._queryMiniThumbnail7152 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "queryMiniThumbnail", "(Landroid/content/ContentResolver;JI[Ljava/lang/String;)Landroid/database/Cursor;");
					global::android.provider.MediaStore.Images.Thumbnails._cancelThumbnailRequest7153 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "cancelThumbnailRequest", "(Landroid/content/ContentResolver;JJ)V");
					global::android.provider.MediaStore.Images.Thumbnails._cancelThumbnailRequest7154 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "cancelThumbnailRequest", "(Landroid/content/ContentResolver;J)V");
					global::android.provider.MediaStore.Images.Thumbnails._Thumbnails7155 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "<init>", "()V");
				}
			}
			internal static global::MonoJavaBridge.MethodId _Images7158;
			public Images()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.Images.staticClass, global::android.provider.MediaStore.Images._Images7158);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.MediaStore.Images.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Images"));
				global::android.provider.MediaStore.Images._Images7158 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.Images.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.MediaStore.MediaColumns_))]
		public interface MediaColumns : BaseColumns
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.MediaStore.MediaColumns))]
		public sealed partial class MediaColumns_ : java.lang.Object, MediaColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static MediaColumns_()
			{
				InitJNI();
			}
			internal MediaColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.MediaStore.MediaColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$MediaColumns"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public static partial class MediaColumnsConstants 
		{
			public static global::java.lang.String DATA
			{
				get
				{
					return "_data";
				}
			}
			public static global::java.lang.String SIZE
			{
				get
				{
					return "_size";
				}
			}
			public static global::java.lang.String DISPLAY_NAME
			{
				get
				{
					return "_display_name";
				}
			}
			public static global::java.lang.String TITLE
			{
				get
				{
					return "title";
				}
			}
			public static global::java.lang.String DATE_ADDED
			{
				get
				{
					return "date_added";
				}
			}
			public static global::java.lang.String DATE_MODIFIED
			{
				get
				{
					return "date_modified";
				}
			}
			public static global::java.lang.String MIME_TYPE
			{
				get
				{
					return "mime_type";
				}
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Video : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Video()
			{
				InitJNI();
			}
			internal Video(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class Media : java.lang.Object, VideoColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static Media()
				{
					InitJNI();
				}
				internal Media(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				internal static global::MonoJavaBridge.MethodId _getContentUri7159;
				public static global::android.net.Uri getContentUri(java.lang.String arg0) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Video.Media.staticClass, global::android.provider.MediaStore.Video.Media._getContentUri7159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
				}
				internal static global::MonoJavaBridge.MethodId _Media7160;
				public Media()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.Video.Media.staticClass, global::android.provider.MediaStore.Video.Media._Media7160);
					Init(@__env, handle);
				}
				internal static global::MonoJavaBridge.FieldId _INTERNAL_CONTENT_URI7161;
				public static global::android.net.Uri INTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				internal static global::MonoJavaBridge.FieldId _EXTERNAL_CONTENT_URI7162;
				public static global::android.net.Uri EXTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				public static global::java.lang.String CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.dir/video";
					}
				}
				public static global::java.lang.String DEFAULT_SORT_ORDER
				{
					get
					{
						return "title";
					}
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Video.Media.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Video$Media"));
					global::android.provider.MediaStore.Video.Media._getContentUri7159 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Video.Media.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;");
					global::android.provider.MediaStore.Video.Media._Media7160 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.Video.Media.staticClass, "<init>", "()V");
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public partial class Thumbnails : java.lang.Object, BaseColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static Thumbnails()
				{
					InitJNI();
				}
				protected Thumbnails(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				internal static global::MonoJavaBridge.MethodId _getThumbnail7163;
				public static global::android.graphics.Bitmap getThumbnail(android.content.ContentResolver arg0, long arg1, int arg2, android.graphics.BitmapFactory.Options arg3) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Video.Thumbnails.staticClass, global::android.provider.MediaStore.Video.Thumbnails._getThumbnail7163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.Bitmap;
				}
				internal static global::MonoJavaBridge.MethodId _getThumbnail7164;
				public static global::android.graphics.Bitmap getThumbnail(android.content.ContentResolver arg0, long arg1, long arg2, int arg3, android.graphics.BitmapFactory.Options arg4) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Video.Thumbnails.staticClass, global::android.provider.MediaStore.Video.Thumbnails._getThumbnail7164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.graphics.Bitmap;
				}
				internal static global::MonoJavaBridge.MethodId _getContentUri7165;
				public static global::android.net.Uri getContentUri(java.lang.String arg0) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Video.Thumbnails.staticClass, global::android.provider.MediaStore.Video.Thumbnails._getContentUri7165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
				}
				internal static global::MonoJavaBridge.MethodId _cancelThumbnailRequest7166;
				public static void cancelThumbnailRequest(android.content.ContentResolver arg0, long arg1) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					@__env.CallStaticVoidMethod(android.provider.MediaStore.Video.Thumbnails.staticClass, global::android.provider.MediaStore.Video.Thumbnails._cancelThumbnailRequest7166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				}
				internal static global::MonoJavaBridge.MethodId _cancelThumbnailRequest7167;
				public static void cancelThumbnailRequest(android.content.ContentResolver arg0, long arg1, long arg2) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					@__env.CallStaticVoidMethod(android.provider.MediaStore.Video.Thumbnails.staticClass, global::android.provider.MediaStore.Video.Thumbnails._cancelThumbnailRequest7167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				}
				internal static global::MonoJavaBridge.MethodId _Thumbnails7168;
				public Thumbnails()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.Video.Thumbnails.staticClass, global::android.provider.MediaStore.Video.Thumbnails._Thumbnails7168);
					Init(@__env, handle);
				}
				internal static global::MonoJavaBridge.FieldId _INTERNAL_CONTENT_URI7169;
				public static global::android.net.Uri INTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				internal static global::MonoJavaBridge.FieldId _EXTERNAL_CONTENT_URI7170;
				public static global::android.net.Uri EXTERNAL_CONTENT_URI
				{
					get
					{
						return default(global::android.net.Uri);
					}
				}
				public static global::java.lang.String DEFAULT_SORT_ORDER
				{
					get
					{
						return "video_id ASC";
					}
				}
				public static global::java.lang.String DATA
				{
					get
					{
						return "_data";
					}
				}
				public static global::java.lang.String VIDEO_ID
				{
					get
					{
						return "video_id";
					}
				}
				public static global::java.lang.String KIND
				{
					get
					{
						return "kind";
					}
				}
				public static int MINI_KIND
				{
					get
					{
						return 1;
					}
				}
				public static int FULL_SCREEN_KIND
				{
					get
					{
						return 2;
					}
				}
				public static int MICRO_KIND
				{
					get
					{
						return 3;
					}
				}
				public static global::java.lang.String WIDTH
				{
					get
					{
						return "width";
					}
				}
				public static global::java.lang.String HEIGHT
				{
					get
					{
						return "height";
					}
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Video.Thumbnails.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Video$Thumbnails"));
					global::android.provider.MediaStore.Video.Thumbnails._getThumbnail7163 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Video.Thumbnails.staticClass, "getThumbnail", "(Landroid/content/ContentResolver;JILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
					global::android.provider.MediaStore.Video.Thumbnails._getThumbnail7164 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Video.Thumbnails.staticClass, "getThumbnail", "(Landroid/content/ContentResolver;JJILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
					global::android.provider.MediaStore.Video.Thumbnails._getContentUri7165 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Video.Thumbnails.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;");
					global::android.provider.MediaStore.Video.Thumbnails._cancelThumbnailRequest7166 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Video.Thumbnails.staticClass, "cancelThumbnailRequest", "(Landroid/content/ContentResolver;J)V");
					global::android.provider.MediaStore.Video.Thumbnails._cancelThumbnailRequest7167 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Video.Thumbnails.staticClass, "cancelThumbnailRequest", "(Landroid/content/ContentResolver;JJ)V");
					global::android.provider.MediaStore.Video.Thumbnails._Thumbnails7168 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.Video.Thumbnails.staticClass, "<init>", "()V");
				}
			}
			[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.MediaStore.Video.VideoColumns_))]
			public interface VideoColumns : MediaColumns
			{
			}

			[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.MediaStore.Video.VideoColumns))]
			public sealed partial class VideoColumns_ : java.lang.Object, VideoColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static VideoColumns_()
				{
					InitJNI();
				}
				internal VideoColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Video.VideoColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Video$VideoColumns"));
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public static partial class VideoColumnsConstants 
			{
				public static global::java.lang.String DURATION
				{
					get
					{
						return "duration";
					}
				}
				public static global::java.lang.String ARTIST
				{
					get
					{
						return "artist";
					}
				}
				public static global::java.lang.String ALBUM
				{
					get
					{
						return "album";
					}
				}
				public static global::java.lang.String RESOLUTION
				{
					get
					{
						return "resolution";
					}
				}
				public static global::java.lang.String DESCRIPTION
				{
					get
					{
						return "description";
					}
				}
				public static global::java.lang.String IS_PRIVATE
				{
					get
					{
						return "isprivate";
					}
				}
				public static global::java.lang.String TAGS
				{
					get
					{
						return "tags";
					}
				}
				public static global::java.lang.String CATEGORY
				{
					get
					{
						return "category";
					}
				}
				public static global::java.lang.String LANGUAGE
				{
					get
					{
						return "language";
					}
				}
				public static global::java.lang.String LATITUDE
				{
					get
					{
						return "latitude";
					}
				}
				public static global::java.lang.String LONGITUDE
				{
					get
					{
						return "longitude";
					}
				}
				public static global::java.lang.String DATE_TAKEN
				{
					get
					{
						return "datetaken";
					}
				}
				public static global::java.lang.String MINI_THUMB_MAGIC
				{
					get
					{
						return "mini_thumb_magic";
					}
				}
				public static global::java.lang.String BUCKET_ID
				{
					get
					{
						return "bucket_id";
					}
				}
				public static global::java.lang.String BUCKET_DISPLAY_NAME
				{
					get
					{
						return "bucket_display_name";
					}
				}
				public static global::java.lang.String BOOKMARK
				{
					get
					{
						return "bookmark";
					}
				}
			}
			internal static global::MonoJavaBridge.MethodId _query7171;
			public static global::android.database.Cursor query(android.content.ContentResolver arg0, android.net.Uri arg1, java.lang.String[] arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallStaticObjectMethod(android.provider.MediaStore.Video.staticClass, global::android.provider.MediaStore.Video._query7171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.database.Cursor;
			}
			internal static global::MonoJavaBridge.MethodId _Video7172;
			public Video()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.Video.staticClass, global::android.provider.MediaStore.Video._Video7172);
				Init(@__env, handle);
			}
			public static global::java.lang.String DEFAULT_SORT_ORDER
			{
				get
				{
					return "_display_name";
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.MediaStore.Video.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Video"));
				global::android.provider.MediaStore.Video._query7171 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Video.staticClass, "query", "(Landroid/content/ContentResolver;Landroid/net/Uri;[Ljava/lang/String;)Landroid/database/Cursor;");
				global::android.provider.MediaStore.Video._Video7172 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.Video.staticClass, "<init>", "()V");
			}
		}
		public static global::android.net.Uri MediaScannerUri
		{
			get
			{
				return getMediaScannerUri();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMediaScannerUri7173;
		public static global::android.net.Uri getMediaScannerUri() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.staticClass, global::android.provider.MediaStore._getMediaScannerUri7173)) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.MethodId _MediaStore7174;
		public MediaStore()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.staticClass, global::android.provider.MediaStore._MediaStore7174);
			Init(@__env, handle);
		}
		public static global::java.lang.String AUTHORITY
		{
			get
			{
				return "media";
			}
		}
		public static global::java.lang.String INTENT_ACTION_MUSIC_PLAYER
		{
			get
			{
				return "android.intent.action.MUSIC_PLAYER";
			}
		}
		public static global::java.lang.String INTENT_ACTION_MEDIA_SEARCH
		{
			get
			{
				return "android.intent.action.MEDIA_SEARCH";
			}
		}
		public static global::java.lang.String EXTRA_MEDIA_ARTIST
		{
			get
			{
				return "android.intent.extra.artist";
			}
		}
		public static global::java.lang.String EXTRA_MEDIA_ALBUM
		{
			get
			{
				return "android.intent.extra.album";
			}
		}
		public static global::java.lang.String EXTRA_MEDIA_TITLE
		{
			get
			{
				return "android.intent.extra.title";
			}
		}
		public static global::java.lang.String EXTRA_MEDIA_FOCUS
		{
			get
			{
				return "android.intent.extra.focus";
			}
		}
		public static global::java.lang.String EXTRA_SCREEN_ORIENTATION
		{
			get
			{
				return "android.intent.extra.screenOrientation";
			}
		}
		public static global::java.lang.String EXTRA_FULL_SCREEN
		{
			get
			{
				return "android.intent.extra.fullScreen";
			}
		}
		public static global::java.lang.String EXTRA_SHOW_ACTION_ICONS
		{
			get
			{
				return "android.intent.extra.showActionIcons";
			}
		}
		public static global::java.lang.String EXTRA_FINISH_ON_COMPLETION
		{
			get
			{
				return "android.intent.extra.finishOnCompletion";
			}
		}
		public static global::java.lang.String INTENT_ACTION_STILL_IMAGE_CAMERA
		{
			get
			{
				return "android.media.action.STILL_IMAGE_CAMERA";
			}
		}
		public static global::java.lang.String INTENT_ACTION_VIDEO_CAMERA
		{
			get
			{
				return "android.media.action.VIDEO_CAMERA";
			}
		}
		public static global::java.lang.String ACTION_IMAGE_CAPTURE
		{
			get
			{
				return "android.media.action.IMAGE_CAPTURE";
			}
		}
		public static global::java.lang.String ACTION_VIDEO_CAPTURE
		{
			get
			{
				return "android.media.action.VIDEO_CAPTURE";
			}
		}
		public static global::java.lang.String EXTRA_VIDEO_QUALITY
		{
			get
			{
				return "android.intent.extra.videoQuality";
			}
		}
		public static global::java.lang.String EXTRA_SIZE_LIMIT
		{
			get
			{
				return "android.intent.extra.sizeLimit";
			}
		}
		public static global::java.lang.String EXTRA_DURATION_LIMIT
		{
			get
			{
				return "android.intent.extra.durationLimit";
			}
		}
		public static global::java.lang.String EXTRA_OUTPUT
		{
			get
			{
				return "output";
			}
		}
		public static global::java.lang.String UNKNOWN_STRING
		{
			get
			{
				return "<unknown>";
			}
		}
		public static global::java.lang.String MEDIA_SCANNER_VOLUME
		{
			get
			{
				return "volume";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.provider.MediaStore.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore"));
			global::android.provider.MediaStore._getMediaScannerUri7173 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.staticClass, "getMediaScannerUri", "()Landroid/net/Uri;");
			global::android.provider.MediaStore._MediaStore7174 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.staticClass, "<init>", "()V");
		}
	}
}
